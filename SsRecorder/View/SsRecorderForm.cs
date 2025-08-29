using SsRecorder.Service;

namespace SsRecorder.View {
    public partial class SsRecorderForm :Form {

        private SsRecorderService _ssRecorder;

        public SsRecorderForm(SsRecorderService ssRecorder) {
            _ssRecorder = ssRecorder;
            InitializeComponent();
        }

        /// <summary>
        /// �X�N�V���͈͑I���{�^�����������Ƃ��̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectCapture_Click(object sender, EventArgs e) {
            _ssRecorder.OpenScreenRangeForm();
        }

        /// <summary>
        /// �ݒ�{�^�����������Ƃ��̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSetting_Click(object sender, EventArgs e) {
            _ssRecorder.OpenSettingForm();
        }

        /// <summary>
        /// �L�^�{�^�����������Ƃ��̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Click(object sender, EventArgs e) {
            int h = int.Parse(TextBoxH.Text == string.Empty ? "0" : TextBoxH.Text);
            int m = int.Parse(TextBoxM.Text == string.Empty ? "0" : TextBoxM.Text);
            int s = int.Parse(TextBoxS.Text == string.Empty ? "0" : TextBoxS.Text);

            var timeSpan = new TimeSpan(h, m, s);

            var word = TextBoxSetWord.Text;
            var analysis = TextBoxSetAnalysis.Text;

            var recordData = new RecordData(timeSpan, word, analysis);
            _ssRecorder.RecordFlow(recordData);
        }
    }
}
