using Microsoft.VisualBasic;
using SsRecorder.Model;
using SsRecorder.Module.Image;
using SsRecorder.Module.ScreenRange;
using SsRecorder.View;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace SsRecorder.Service {

    // ViewとModelの仲介役
    // Excelの書き込みもここで行う
    public class SsRecorderService {

        private SsRecorderModel _model;

        public SsRecorderService() {
            _model = new SsRecorderModel();
        }

        /// <summary>
        /// スクショ範囲設定フォームを開く
        /// </summary>
        public void OpenScreenRangeForm() {
            // スクショ範囲選択UIを表示→OKの通知まで待つ
            var screenRange = new ScreenRangeForm();
            if (screenRange.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("範囲を選択しました");
                _model.SetScreenRange(screenRange.SelectedRegion);
            }
        }

        /// <summary>
        /// 設定フォームを開く
        /// </summary>
        public void OpenSettingForm() {
            _model.LoadSetting();
            var settingForm = new SsRecorderSettingForm(_model.Settings, SaveSetting);
            settingForm.ShowDialog();
        }

        /// <summary>
        /// 設定を保存する
        /// </summary>
        /// <param name="data"></param>
        public void SaveSetting(SettingJsonData data) {
            _model.SaveSetting(data);
            MessageBox.Show("設定を保存しました。");
        }

        /// <summary>
        /// Excelに記録する処理の流れ
        /// </summary>
        /// <param name="data"></param>
        public void RecordFlow(RecordData data) {
            if (_model.ScreenRange.IsEmpty) {
                MessageBox.Show("スクショ範囲が選択されていません。\n「スクショ範囲選択」ボタンで選択してください");
                return;
            }

            if (string.IsNullOrEmpty(_model.Settings.Link)) {
                MessageBox.Show("「設定」からリンクを設定してください");
                return;
            }

            string excelPath = _model.Settings.ExcelPath;
            if (string.IsNullOrEmpty(excelPath)) {
                MessageBox.Show("「設定」から記録するExcelファイルを設定してください");
                return;
            }

            if (!File.Exists(excelPath)) {
                MessageBox.Show("記録するExcelファイルが見つかりません。もう一度設定してください");
                return;
            }

            string tempDir = ConstSsRecorder.TEMP_IMAGE_DIR_PATH;
            Directory.CreateDirectory(tempDir);
            string ss = Path.Combine(tempDir, $"shot_{DateTime.Now:yyyyMMdd_HHmmssfff}.png");

            // スクショ
            var shooter = new ScreenShotter();
            shooter.CaptureScreenshot(_model.ScreenRange, ss);

            // スクショサイズ軽量化
            var resizer = new ImageResizer();
            var resizedSsPath = resizer.ResizeImageIfNecessary(ss, _model.Settings.MaxWidth, _model.Settings.MaxHeight);

            // urlの取得
            var link = _model.Settings.Link;
            var totalSeconds = (int)data.TimeSpan.TotalSeconds;
            if (_model.Settings.IsSecondsLink) {
                link = $"{link}&t={totalSeconds}s";
            }

            // Excelに書き込み
            var excelColumnData = new ExcelColumns(resizedSsPath, totalSeconds, data.Word, data.Analysis, link);
            WriteToExcel(excelPath, excelColumnData);

            // 画像の破棄
            foreach (var file in Directory.GetFiles(tempDir)) {
                try {
                    File.Delete(file);
                } catch (Exception ex) {
                    Console.WriteLine($"一時ファイルの削除に失敗: {file} - {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Excelに書き込む
        /// </summary>
        /// <param name="excelPath"></param>
        /// <param name="data"></param>
        /// <exception cref="InvalidOperationException"></exception>
        private void WriteToExcel(string excelPath, ExcelColumns data) {
            Excel.Workbook workbook = null;
            Excel.Application app = null;

            try {
                if (!IsWorkbookOpenByExcel(excelPath)) {
                    throw new InvalidOperationException($"記録するExcelファイルが開いておりません。開いてからもう一度記録してください。\nパス: {excelPath}");
                }

                // 開いているExcelを取得
                workbook = (Excel.Workbook)Interaction.GetObject(excelPath);
                app = workbook.Application;

                // 念のため、取得できたものが同一パスか確認
                if (!PathsEqual(workbook.FullName, excelPath)) {
                    throw new InvalidOperationException("取得した Workbook が対象と一致しません。");
                }

                bool originalAlerts = app.DisplayAlerts;
                app.DisplayAlerts = false; // メッセージがうるさいので、いったん止める

                try {
                    string macro = $"'{Path.GetFileName(workbook.FullName)}'{ConstSsRecorder.MACRO_NAME}";
                    app.Run(macro, data.ImgPath, data.Seconds, data.Word, data.Analysis, data.Url);
                    workbook.Save();
                } finally {
                    app.DisplayAlerts = originalAlerts;
                }
            } catch (COMException ex) {
                // 別権限（管理者/非管理者）や別ユーザーセッション等のエラー
                MessageBox.Show($"Excelへの書き込みに失敗しました。\nCOM エラー: 0x{(uint)ex.HResult:X8}\n{ex.Message}");
            } catch (Exception ex) {
                MessageBox.Show($"Excelへの書き込みに失敗しました。\n{ex.Message}");
            } finally {
                if (workbook != null) {
                    Marshal.FinalReleaseComObject(workbook);
                }   
                if (app != null) {
                    Marshal.FinalReleaseComObject(app);
                }
            }
        }

        /// <summary>
        /// パスが一致しているか
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private bool PathsEqual(string a, string b) {
            string fa = Path.GetFullPath(a);
            string fb = Path.GetFullPath(b);
            return string.Equals(fa, fb, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Excelファイルが開かれているか
        /// これらのどちらかが真なら「Excelで開いている」と判断
        /// </summary>
        private bool IsWorkbookOpenByExcel(string fullPath) {
            // 排他ロック
            if (IsFileLocked(fullPath))
                return true;

            // ~$xxxx.xlsx の存在確認
            string dir = Path.GetDirectoryName(fullPath) ?? ".";
            string name = Path.GetFileName(fullPath);
            string lockFile = Path.Combine(dir, "~$" + name);
            if (File.Exists(lockFile))
                return true;

            return false;
        }

        /// <summary>
        /// Excelがロックされているか
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private bool IsFileLocked(string path) {
            try {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None)) {
                    // 開けた＝誰もロックしていない
                }
                return false;
            } catch (IOException) {
                // IOException：他プロセスによりロックされている可能性が高い
                return true;
            }
        }
    }
}
