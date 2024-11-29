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
            labelEnterKey = new Label();
            SuspendLayout();
            // 
            // textCryptedText
            // 
            textCryptedText.Location = new Point(10, 31);
            textCryptedText.Margin = new Padding(3, 2, 3, 2);
            textCryptedText.Multiline = true;
            textCryptedText.Name = "textCryptedText";
            textCryptedText.PlaceholderText = "Enter crypted text...";
            textCryptedText.ScrollBars = ScrollBars.Vertical;
            textCryptedText.Size = new Size(291, 99);
            textCryptedText.TabIndex = 0;
            // 
            // labelEnterCryptedText
            // 
            labelEnterCryptedText.AutoSize = true;
            labelEnterCryptedText.Location = new Point(10, 7);
            labelEnterCryptedText.Name = "labelEnterCryptedText";
            labelEnterCryptedText.Size = new Size(103, 15);
            labelEnterCryptedText.TabIndex = 1;
            labelEnterCryptedText.Text = "Enter Crypted Text";
            // 
            // labelProcessedText
            // 
            labelProcessedText.AutoSize = true;
            labelProcessedText.Location = new Point(10, 140);
            labelProcessedText.Name = "labelProcessedText";
            labelProcessedText.Size = new Size(84, 15);
            labelProcessedText.TabIndex = 2;
            labelProcessedText.Text = "Processed Text";
            // 
            // textProcessedText
            // 
            textProcessedText.Location = new Point(10, 159);
            textProcessedText.Margin = new Padding(3, 2, 3, 2);
            textProcessedText.Multiline = true;
            textProcessedText.Name = "textProcessedText";
            textProcessedText.PlaceholderText = "The result will be shown here...";
            textProcessedText.ReadOnly = true;
            textProcessedText.ScrollBars = ScrollBars.Vertical;
            textProcessedText.Size = new Size(291, 96);
            textProcessedText.TabIndex = 3;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(318, 31);
            buttonReset.Margin = new Padding(3, 2, 3, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(134, 26);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonFindSequences
            // 
            buttonFindSequences.Location = new Point(318, 159);
            buttonFindSequences.Margin = new Padding(3, 2, 3, 2);
            buttonFindSequences.Name = "buttonFindSequences";
            buttonFindSequences.Size = new Size(134, 96);
            buttonFindSequences.TabIndex = 5;
            buttonFindSequences.Text = "Find Sequences";
            buttonFindSequences.UseVisualStyleBackColor = true;
            // 
            // textKey
            // 
            textKey.Location = new Point(511, 34);
            textKey.Margin = new Padding(3, 2, 3, 2);
            textKey.Name = "textKey";
            textKey.PlaceholderText = "Enter Key...";
            textKey.Size = new Size(110, 23);
            textKey.TabIndex = 1;
            // 
            // labelEnterKey
            // 
            labelEnterKey.AutoSize = true;
            labelEnterKey.Location = new Point(514, 10);
            labelEnterKey.Name = "labelEnterKey";
            labelEnterKey.Size = new Size(56, 15);
            labelEnterKey.TabIndex = 7;
            labelEnterKey.Text = "Enter Key";
            // 
            // KasiskiAnalyzer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 272);
            Controls.Add(labelEnterKey);
            Controls.Add(textKey);
            Controls.Add(buttonFindSequences);
            Controls.Add(buttonReset);
            Controls.Add(textProcessedText);
            Controls.Add(labelProcessedText);
            Controls.Add(labelEnterCryptedText);
            Controls.Add(textCryptedText);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1024, 315);
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
        private Label labelEnterKey;
        private Button buttonReset;
        private Button buttonFindSequences;

        private TextHandler textHandler = new TextHandler();
    }
}
