namespace SsRecorder.View
{
    partial class SsRecorderForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            TextStopwatch = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BtnSelectCapture = new Button();
            BtnSetting = new Button();
            BtnRecord = new Button();
            TextBoxH = new TextBox();
            label8 = new Label();
            label1 = new Label();
            TextBoxSetWord = new TextBox();
            label2 = new Label();
            TextBoxSetAnalysis = new TextBox();
            TextBoxM = new TextBox();
            TextBoxS = new TextBox();
            SuspendLayout();
            // 
            // TextStopwatch
            // 
            TextStopwatch.AutoSize = true;
            TextStopwatch.Font = new Font("MS UI Gothic", 40F, FontStyle.Regular, GraphicsUnit.Point, 128);
            TextStopwatch.ImageAlign = ContentAlignment.BottomLeft;
            TextStopwatch.Location = new Point(21, 104);
            TextStopwatch.Name = "TextStopwatch";
            TextStopwatch.RightToLeft = RightToLeft.Yes;
            TextStopwatch.Size = new Size(0, 80);
            TextStopwatch.TabIndex = 4;
            // 
            // BtnSelectCapture
            // 
            BtnSelectCapture.BackColor = SystemColors.Control;
            BtnSelectCapture.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            BtnSelectCapture.Location = new Point(583, 104);
            BtnSelectCapture.Margin = new Padding(3, 4, 3, 4);
            BtnSelectCapture.Name = "BtnSelectCapture";
            BtnSelectCapture.Size = new Size(205, 111);
            BtnSelectCapture.TabIndex = 6;
            BtnSelectCapture.Text = "スクショ範囲選択";
            BtnSelectCapture.UseVisualStyleBackColor = false;
            BtnSelectCapture.Click += BtnSelectCapture_Click;
            // 
            // BtnSetting
            // 
            BtnSetting.BackColor = SystemColors.Control;
            BtnSetting.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            BtnSetting.Location = new Point(583, 249);
            BtnSetting.Margin = new Padding(3, 4, 3, 4);
            BtnSetting.Name = "BtnSetting";
            BtnSetting.Size = new Size(205, 111);
            BtnSetting.TabIndex = 8;
            BtnSetting.Text = "設定";
            BtnSetting.UseVisualStyleBackColor = false;
            BtnSetting.Click += BtnSetting_Click;
            // 
            // BtnRecord
            // 
            BtnRecord.BackColor = Color.White;
            BtnRecord.Font = new Font("MS UI Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 128);
            BtnRecord.ImageAlign = ContentAlignment.BottomLeft;
            BtnRecord.Location = new Point(583, 395);
            BtnRecord.Margin = new Padding(3, 4, 3, 4);
            BtnRecord.Name = "BtnRecord";
            BtnRecord.Size = new Size(205, 111);
            BtnRecord.TabIndex = 9;
            BtnRecord.Text = "記録する";
            BtnRecord.UseVisualStyleBackColor = false;
            BtnRecord.Click += BtnSubmit_Click;
            // 
            // TextBoxH
            // 
            TextBoxH.Location = new Point(171, 35);
            TextBoxH.Margin = new Padding(3, 4, 3, 4);
            TextBoxH.Name = "TextBoxH";
            TextBoxH.Size = new Size(45, 31);
            TextBoxH.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(75, 39);
            label8.Name = "label8";
            label8.Size = new Size(80, 25);
            label8.TabIndex = 20;
            label8.Text = "時/分/秒";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 108);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 22;
            label1.Text = "単語";
            // 
            // TextBoxSetWord
            // 
            TextBoxSetWord.Location = new Point(171, 104);
            TextBoxSetWord.Margin = new Padding(3, 4, 3, 4);
            TextBoxSetWord.Name = "TextBoxSetWord";
            TextBoxSetWord.Size = new Size(292, 31);
            TextBoxSetWord.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 179);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 24;
            label2.Text = "言語化";
            // 
            // TextBoxSetAnalysis
            // 
            TextBoxSetAnalysis.Location = new Point(171, 189);
            TextBoxSetAnalysis.Margin = new Padding(3, 4, 3, 4);
            TextBoxSetAnalysis.Multiline = true;
            TextBoxSetAnalysis.Name = "TextBoxSetAnalysis";
            TextBoxSetAnalysis.Size = new Size(375, 317);
            TextBoxSetAnalysis.TabIndex = 23;
            // 
            // TextBoxM
            // 
            TextBoxM.Location = new Point(246, 35);
            TextBoxM.Margin = new Padding(3, 4, 3, 4);
            TextBoxM.Name = "TextBoxM";
            TextBoxM.Size = new Size(45, 31);
            TextBoxM.TabIndex = 25;
            // 
            // TextBoxS
            // 
            TextBoxS.Location = new Point(326, 35);
            TextBoxS.Margin = new Padding(3, 4, 3, 4);
            TextBoxS.Name = "TextBoxS";
            TextBoxS.Size = new Size(45, 31);
            TextBoxS.TabIndex = 26;
            // 
            // SsRecorderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 578);
            Controls.Add(TextBoxS);
            Controls.Add(TextBoxM);
            Controls.Add(label2);
            Controls.Add(TextBoxSetAnalysis);
            Controls.Add(label1);
            Controls.Add(TextBoxSetWord);
            Controls.Add(label8);
            Controls.Add(TextBoxH);
            Controls.Add(BtnRecord);
            Controls.Add(BtnSetting);
            Controls.Add(BtnSelectCapture);
            Controls.Add(TextStopwatch);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SsRecorderForm";
            Text = "SsRecorder";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextStopwatch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label TextRecordingState;
        private System.Windows.Forms.Button BtnSelectCapture;
        private System.Windows.Forms.Button BtnSetting;
        private System.Windows.Forms.Button BtnRecord;
        private System.Windows.Forms.TextBox TextBoxH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxSetWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxSetAnalysis;
        private System.Windows.Forms.TextBox TextBoxM;
        private System.Windows.Forms.TextBox TextBoxS;
    }
}
