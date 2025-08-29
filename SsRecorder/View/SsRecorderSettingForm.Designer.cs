namespace SsRecorder.View {
    partial class SsRecorderSettingForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            TextSheetNameTitle = new Label();
            TextMaxWidthTitle = new Label();
            TextMaxHightTitle = new Label();
            TextBoxExcelPath = new TextBox();
            NumMaxWidth = new NumericUpDown();
            groupBox2 = new GroupBox();
            btnSelectFile = new Button();
            groupBox3 = new GroupBox();
            NumMaxHight = new NumericUpDown();
            BtnSave = new Button();
            groupBox4 = new GroupBox();
            CheckBoxSeconds = new CheckBox();
            TextBoxLink = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)NumMaxWidth).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumMaxHight).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // TextSheetNameTitle
            // 
            TextSheetNameTitle.AutoSize = true;
            TextSheetNameTitle.Location = new Point(18, 53);
            TextSheetNameTitle.Name = "TextSheetNameTitle";
            TextSheetNameTitle.Size = new Size(133, 25);
            TextSheetNameTitle.TabIndex = 5;
            TextSheetNameTitle.Text = "記録するExcel：";
            // 
            // TextMaxWidthTitle
            // 
            TextMaxWidthTitle.AutoSize = true;
            TextMaxWidthTitle.Location = new Point(12, 37);
            TextMaxWidthTitle.Name = "TextMaxWidthTitle";
            TextMaxWidthTitle.Size = new Size(131, 25);
            TextMaxWidthTitle.TabIndex = 7;
            TextMaxWidthTitle.Text = "最大横幅(px)：";
            // 
            // TextMaxHightTitle
            // 
            TextMaxHightTitle.AutoSize = true;
            TextMaxHightTitle.Location = new Point(339, 37);
            TextMaxHightTitle.Name = "TextMaxHightTitle";
            TextMaxHightTitle.Size = new Size(131, 25);
            TextMaxHightTitle.TabIndex = 8;
            TextMaxHightTitle.Text = "最大縦幅(px)：";
            // 
            // TextBoxExcelPath
            // 
            TextBoxExcelPath.Location = new Point(150, 53);
            TextBoxExcelPath.Name = "TextBoxExcelPath";
            TextBoxExcelPath.Size = new Size(500, 31);
            TextBoxExcelPath.TabIndex = 11;
            // 
            // NumMaxWidth
            // 
            NumMaxWidth.Location = new Point(140, 35);
            NumMaxWidth.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            NumMaxWidth.Name = "NumMaxWidth";
            NumMaxWidth.Size = new Size(120, 31);
            NumMaxWidth.TabIndex = 13;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSelectFile);
            groupBox2.Controls.Add(TextSheetNameTitle);
            groupBox2.Controls.Add(TextBoxExcelPath);
            groupBox2.Location = new Point(26, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(778, 105);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "【Excel設定】";
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(656, 51);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(112, 34);
            btnSelectFile.TabIndex = 12;
            btnSelectFile.Text = "ファイル選択";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(NumMaxHight);
            groupBox3.Controls.Add(TextMaxWidthTitle);
            groupBox3.Controls.Add(TextMaxHightTitle);
            groupBox3.Controls.Add(NumMaxWidth);
            groupBox3.Location = new Point(26, 373);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(778, 89);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "【キャプチャ設定】";
            // 
            // NumMaxHight
            // 
            NumMaxHight.Location = new Point(465, 37);
            NumMaxHight.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            NumMaxHight.Name = "NumMaxHight";
            NumMaxHight.Size = new Size(120, 31);
            NumMaxHight.TabIndex = 14;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = SystemColors.Window;
            BtnSave.ForeColor = SystemColors.WindowText;
            BtnSave.Location = new Point(682, 489);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(120, 30);
            BtnSave.TabIndex = 16;
            BtnSave.Text = "保存";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(CheckBoxSeconds);
            groupBox4.Controls.Add(TextBoxLink);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label2);
            groupBox4.Location = new Point(26, 194);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(778, 140);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "【参照動画設定】";
            // 
            // CheckBoxSeconds
            // 
            CheckBoxSeconds.AutoSize = true;
            CheckBoxSeconds.Location = new Point(229, 97);
            CheckBoxSeconds.Name = "CheckBoxSeconds";
            CheckBoxSeconds.Size = new Size(22, 21);
            CheckBoxSeconds.TabIndex = 13;
            CheckBoxSeconds.UseVisualStyleBackColor = true;
            // 
            // TextBoxLink
            // 
            TextBoxLink.Location = new Point(150, 40);
            TextBoxLink.Name = "TextBoxLink";
            TextBoxLink.Size = new Size(500, 31);
            TextBoxLink.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 40);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 7;
            label1.Text = "リンク：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 93);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 8;
            label2.Text = "秒数付きリンクにするか：";
            // 
            // SsRecorderSettingForm
            // 
            ClientSize = new Size(816, 550);
            Controls.Add(groupBox4);
            Controls.Add(BtnSave);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "SsRecorderSettingForm";
            Text = "SsRecorder - 設定";
            ((System.ComponentModel.ISupportInitialize)NumMaxWidth).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumMaxHight).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TextSheetNameTitle;
        private System.Windows.Forms.Label TextMaxWidthTitle;
        private System.Windows.Forms.Label TextMaxHightTitle;
        private System.Windows.Forms.TextBox TextBoxExcelPath;
        private System.Windows.Forms.NumericUpDown NumMaxWidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown NumMaxHight;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxLink;
        private System.Windows.Forms.CheckBox CheckBoxSeconds;
        private Button btnSelectFile;
    }
}