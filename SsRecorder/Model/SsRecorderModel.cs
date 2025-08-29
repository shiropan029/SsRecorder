using SsRecorder.Service;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace SsRecorder.Model {

    // 設定やデータを保存する
    public class SsRecorderModel {

        // スクショの範囲
        public Rectangle ScreenRange { get; private set; }
        public SettingJsonData Settings { get; private set; } = new SettingJsonData();

        public SsRecorderModel() {
            LoadSetting();
        }

        /// <summary>
        /// スクショ範囲を設定する
        /// </summary>
        /// <param name="range"></param>
        public void SetScreenRange(Rectangle range) {
            ScreenRange = range;
        }

        /// <summary>
        /// 設定を保存する
        /// </summary>
        /// <param name="data"></param>
        public void SaveSetting(SettingJsonData data) {
            JsonSerializerOptions options = new JsonSerializerOptions {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All), // 日本語が表示できるようにする
                WriteIndented = true, // インデントフォーマットあり
            };
            
            string json = JsonSerializer.Serialize(data, options);
            File.WriteAllText(ConstSsRecorder.SETTING_JSON_PATH, json);
            LoadSetting();
        }

        /// <summary>
        /// 設定を読み込む
        /// </summary>
        public void LoadSetting() {
            if (File.Exists(ConstSsRecorder.SETTING_JSON_PATH)) {
                string json = File.ReadAllText(ConstSsRecorder.SETTING_JSON_PATH);
                Settings = JsonSerializer.Deserialize<SettingJsonData>(json) ?? new SettingJsonData();
            } else {
                Settings = new SettingJsonData();
            }
        }
    }
}
