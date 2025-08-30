namespace SsRecorder.Service {

    /// <summary>
    /// formから記録する際に送るデータ
    /// </summary>
    public class RecordData {
        public readonly TimeSpan TimeSpan;
        public readonly string Word = string.Empty;
        public readonly string Analysis = string.Empty;

        public RecordData(TimeSpan timeSpan, string word, string analysis) {
            TimeSpan = timeSpan;
            Word = word;
            Analysis = analysis;
        }
    }
}
