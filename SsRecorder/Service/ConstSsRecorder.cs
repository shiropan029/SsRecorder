namespace SsRecorder.Service {
    public class ConstSsRecorder {

        // 設定ファイルのパス
        public static string SETTING_JSON_PATH { get {
                var path = Path.Combine(Environment.CurrentDirectory, "setting.json");
                return path;
            }
        }

        // 一時画像保存フォルダのパス
        public static string TEMP_IMAGE_DIR_PATH {
            get {
                var path = Path.Combine(Environment.CurrentDirectory, "Temp");
                if (!Directory.Exists(path)) {
                    Directory.CreateDirectory(path);
                }
                return path;
            }
        }

        // 圧縮後の画像サイズ(16:9)
        public const int DefaultWidth = 256;
        public const int DefaultHeight = 144;

        // Excelに記録するマクロ名（モジュール名.プロシージャ名）
        public const string MACRO_NAME = "!insertAnalysisData.insertAnalysisData";
    }
}
