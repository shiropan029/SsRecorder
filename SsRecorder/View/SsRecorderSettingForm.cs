using SsRecorder.Service;

namespace SsRecorder.View {
    public partial class SsRecorderSettingForm :Form {

        /// <summary>
        /// 保存するときに呼ぶ関数
        /// </summary>
        private Action<SettingJsonData> _onSaveSetting;

        public SsRecorderSettingForm(SettingJsonData data, Action<SettingJsonData> onSaveSetting) {
            _onSaveSetting = onSaveSetting;
            InitializeComponent();
            SetSettings(data);
        }

        /// <summary>
        /// 設定をUIに反映する
        /// </summary>
        /// <param name="data"></param>
        private void SetSettings(SettingJsonData data) {
            TextBoxExcelPath.Text = data.ExcelPath;
            TextBoxLink.Text = data.Link;
            CheckBoxSeconds.Checked = data.IsSecondsLink;
            NumMaxWidth.Value = data.MaxWidth;
            NumMaxHight.Value = data.MaxHeight;
        }

        /// <summary>
        /// 保存ボタンを押したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e) {
            var newSettingData = new SettingJsonData(
                TextBoxExcelPath.Text,
                TextBoxLink.Text,
                CheckBoxSeconds.Checked,
                (int)NumMaxWidth.Value,
                (int)NumMaxHight.Value
                );
            _onSaveSetting(newSettingData);
            this.Close();
        }

        /// <summary>
        /// ファイル選択ボタンを押したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFile_Click(object sender, EventArgs e) {
            var path = SelectFile();
            TextBoxExcelPath.Text = path;            
        }

        /// <summary>
        /// 設定ファイル選択ダイアログを開き、Excelファイルを選ばせる
        /// </summary>
        /// <returns></returns>
        private string SelectFile() {
            var path = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Title = "記録するExcelファイルを選択してください";
                openFileDialog.Filter = "マクロ有効Excelファイル|*.xlsm";

                //ファイル選択ダイアログを開く
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    path = openFileDialog.FileName;
                }
            }
            return path;
        }
    }
}
