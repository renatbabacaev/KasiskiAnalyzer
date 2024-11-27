namespace KasiskiAnalyzer
{
    partial class KasiskiAnalyzer
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
            labelEnterCryptedText = new Label();
            labelProcessedText = new Label();
            textProcessedText = new TextBox();
            buttonReset = new Button();
            buttonFindSequences = new Button();
            textKey = new TextBox();
            textEnterKey = new Label();
            SuspendLayout();
            // 
            // textCryptedText
            // 
            textCryptedText.Location = new Point(12, 41);
            textCryptedText.Multiline = true;
            textCryptedText.Name = "textCryptedText";
            textCryptedText.PlaceholderText = "Enter crypted text...";
            textCryptedText.ScrollBars = ScrollBars.Vertical;
            textCryptedText.Size = new Size(332, 131);
            textCryptedText.TabIndex = 0;
            // 
            // labelEnterCryptedText
            // 
            labelEnterCryptedText.AutoSize = true;
            labelEnterCryptedText.Location = new Point(12, 9);
            labelEnterCryptedText.Name = "labelEnterCryptedText";
            labelEnterCryptedText.Size = new Size(130, 20);
            labelEnterCryptedText.TabIndex = 1;
            labelEnterCryptedText.Text = "Enter Crypted Text";
            // 
            // labelProcessedText
            // 
            labelProcessedText.AutoSize = true;
            labelProcessedText.Location = new Point(12, 186);
            labelProcessedText.Name = "labelProcessedText";
            labelProcessedText.Size = new Size(106, 20);
            labelProcessedText.TabIndex = 2;
            labelProcessedText.Text = "Processed Text";
            // 
            // textProcessedText
            // 
            textProcessedText.Location = new Point(12, 212);
            textProcessedText.Multiline = true;
            textProcessedText.Name = "textProcessedText";
            textProcessedText.PlaceholderText = "The result will be shown here...";
            textProcessedText.ReadOnly = true;
            textProcessedText.ScrollBars = ScrollBars.Vertical;
            textProcessedText.Size = new Size(332, 127);
            textProcessedText.TabIndex = 3;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(364, 41);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(153, 35);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonFindSequences
            // 
            buttonFindSequences.Location = new Point(364, 212);
            buttonFindSequences.Name = "buttonFindSequences";
            buttonFindSequences.Size = new Size(153, 128);
            buttonFindSequences.TabIndex = 5;
            buttonFindSequences.Text = "Find Sequences";
            buttonFindSequences.UseVisualStyleBackColor = true;
            // 
            // textKey
            // 
            textKey.Location = new Point(584, 46);
            textKey.Name = "textKey";
            textKey.PlaceholderText = "Enter Key...";
            textKey.Size = new Size(125, 27);
            textKey.TabIndex = 6;
            // 
            // textEnterKey
            // 
            textEnterKey.AutoSize = true;
            textEnterKey.Location = new Point(587, 14);
            textEnterKey.Name = "textEnterKey";
            textEnterKey.Size = new Size(71, 20);
            textEnterKey.TabIndex = 7;
            textEnterKey.Text = "Enter Key";
            // 
            // KasiskiAnalyzer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 362);
            Controls.Add(textEnterKey);
            Controls.Add(textKey);
            Controls.Add(buttonFindSequences);
            Controls.Add(buttonReset);
            Controls.Add(textProcessedText);
            Controls.Add(labelProcessedText);
            Controls.Add(labelEnterCryptedText);
            Controls.Add(textCryptedText);
            Name = "KasiskiAnalyzer";
            Text = "Kasiski Analyzer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textCryptedText;
        private TextBox textProcessedText;
        private TextBox textKey;
        private Label labelEnterCryptedText;
        private Label labelProcessedText;
        private Label textEnterKey;
        private Button buttonReset;
        private Button buttonFindSequences;

        private TextHandler textHandler = new TextHandler();
    }
}
