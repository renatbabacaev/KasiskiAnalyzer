namespace KasiskiAnalyzer
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textCryptedText = new TextBox();
            textProcessedText = new TextBox();
            buttonReset = new Button();
            buttonFindSequences = new Button();
            textKey = new TextBox();
            groupProcessed = new GroupBox();
            groupCrypted = new GroupBox();
            splitContainer1 = new SplitContainer();
            groupProcessed.SuspendLayout();
            groupCrypted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // textCryptedText
            // 
            textCryptedText.Location = new Point(6, 25);
            textCryptedText.Margin = new Padding(3, 2, 3, 2);
            textCryptedText.Multiline = true;
            textCryptedText.Name = "textCryptedText";
            textCryptedText.PlaceholderText = "Enter crypted text...";
            textCryptedText.ScrollBars = ScrollBars.Vertical;
            textCryptedText.Size = new Size(429, 468);
            textCryptedText.TabIndex = 0;
            // 
            // textProcessedText
            // 
            textProcessedText.Location = new Point(6, 25);
            textProcessedText.Margin = new Padding(3, 2, 3, 2);
            textProcessedText.Multiline = true;
            textProcessedText.Name = "textProcessedText";
            textProcessedText.PlaceholderText = "The result will be shown here...";
            textProcessedText.ReadOnly = true;
            textProcessedText.ScrollBars = ScrollBars.Vertical;
            textProcessedText.Size = new Size(431, 495);
            textProcessedText.TabIndex = 3;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(6, 527);
            buttonReset.Margin = new Padding(3, 2, 3, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(431, 77);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonFindSequences
            // 
            buttonFindSequences.Location = new Point(6, 527);
            buttonFindSequences.Margin = new Padding(3, 2, 3, 2);
            buttonFindSequences.Name = "buttonFindSequences";
            buttonFindSequences.Size = new Size(429, 77);
            buttonFindSequences.TabIndex = 5;
            buttonFindSequences.Text = "Find Sequences";
            buttonFindSequences.UseVisualStyleBackColor = true;
            // 
            // textKey
            // 
            textKey.Location = new Point(9, 500);
            textKey.Margin = new Padding(3, 2, 3, 2);
            textKey.Name = "textKey";
            textKey.PlaceholderText = "Enter Key...";
            textKey.Size = new Size(429, 23);
            textKey.TabIndex = 1;
            // 
            // groupProcessed
            // 
            groupProcessed.Controls.Add(buttonReset);
            groupProcessed.Controls.Add(textProcessedText);
            groupProcessed.Location = new Point(3, 3);
            groupProcessed.Name = "groupProcessed";
            groupProcessed.Size = new Size(443, 609);
            groupProcessed.TabIndex = 8;
            groupProcessed.TabStop = false;
            groupProcessed.Text = "Processed Text";
            // 
            // groupCrypted
            // 
            groupCrypted.Controls.Add(buttonFindSequences);
            groupCrypted.Controls.Add(textCryptedText);
            groupCrypted.Location = new Point(3, 3);
            groupCrypted.Name = "groupCrypted";
            groupCrypted.Size = new Size(441, 612);
            groupCrypted.TabIndex = 9;
            groupCrypted.TabStop = false;
            groupCrypted.Text = "Crypted Text";
            // 
            // splitContainer1
            // 
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textKey);
            splitContainer1.Panel1.Controls.Add(groupCrypted);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupProcessed);
            splitContainer1.Size = new Size(900, 615);
            splitContainer1.SplitterDistance = 446;
            splitContainer1.TabIndex = 10;
            splitContainer1.TabStop = false;
            // 
            // KasiskiAnalyzer
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(924, 634);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "KasiskiAnalyzer";
            Text = "Kasiski Analyzer";
            groupProcessed.ResumeLayout(false);
            groupProcessed.PerformLayout();
            groupCrypted.ResumeLayout(false);
            groupCrypted.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public static TextBox textCryptedText;
        public static TextBox textProcessedText;
        public TextBox textKey;
        private Button buttonReset;
        private Button buttonFindSequences;

        public static TextHandler textHandler = new TextHandler();
        private GroupBox groupProcessed;
        private GroupBox groupCrypted;
        private SplitContainer splitContainer1;
    }
}
