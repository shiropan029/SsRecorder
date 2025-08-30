namespace SsRecorder.Service {

    // 分析情報を書き込むシートの各項目
    public class ExcelColumns {
    
        public readonly string ImgPath = string.Empty;
        public readonly int Seconds = 0;
        public readonly string Word = string.Empty;
        public readonly string Analysis = string.Empty;
        public readonly string Url = string.Empty;

        public ExcelColumns(string imgPath, int seconds, string word, string analysis, string url) {
            ImgPath = imgPath;
            Seconds = seconds;
            Word = word;
            Analysis = analysis;
            Url = url;
        }
    }
}
