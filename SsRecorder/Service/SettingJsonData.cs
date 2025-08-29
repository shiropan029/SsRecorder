using System.Text.Json.Serialization;

namespace SsRecorder.Service {
    public class SettingJsonData {
        // readonlyだとJsonの読み書きができないので、自動実装プロパティ
        public string ExcelPath { get; private set; } = string.Empty;
        public string Link { get; private set; } = string.Empty;
        public bool IsSecondsLink { get; private set; }
        public int MaxWidth { get; private set; } = ConstSsRecorder.DefaultWidth;
        public int MaxHeight { get; private set; } = ConstSsRecorder.DefaultHeight;

        public SettingJsonData() { }

        [JsonConstructor]
        public SettingJsonData(string excelPath, string link, bool isSecondsLink, int maxWidth, int maxHeight) {
            ExcelPath = excelPath ?? string.Empty;
            Link = link ?? string.Empty;
            IsSecondsLink = isSecondsLink;
            MaxWidth = maxWidth;
            MaxHeight = maxHeight;
        }
    }
}
