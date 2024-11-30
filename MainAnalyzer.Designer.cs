using System.Text;

namespace KasiskiAnalyzer
{
    partial class MainAnalyzer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            keyInput = new TextBox();
            groupBox1 = new GroupBox();
            keyLength = new NumericUpDown();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            selectLetter = new NumericUpDown();
            groupBox4 = new GroupBox();
            shiftLetter = new NumericUpDown();
            keyChar = new Label();
            buttonReset = new Button();
            buttonCopy = new Button();
            ((System.ComponentModel.ISupportInitialize)keyLength).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectLetter).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shiftLetter).BeginInit();
            SuspendLayout();
            // 
            // keyInput
            // 
            keyInput.Location = new Point(13, 70);
            keyInput.Name = "keyInput";
            keyInput.PlaceholderText = "Enter Key...";
            keyInput.Size = new Size(227, 23);
            keyInput.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(13, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1026, 513);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Analysis Results";
            // 
            // keyLength
            // 
            keyLength.Location = new Point(6, 22);
            keyLength.Name = "keyLength";
            keyLength.Size = new Size(69, 23);
            keyLength.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(keyLength);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(81, 52);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Key Length";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(selectLetter);
            groupBox3.Location = new Point(99, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(87, 52);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Select Letter";
            // 
            // selectLetter
            // 
            selectLetter.Location = new Point(6, 22);
            selectLetter.Name = "selectLetter";
            selectLetter.Size = new Size(75, 23);
            selectLetter.TabIndex = 0;
            selectLetter.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(shiftLetter);
            groupBox4.Location = new Point(192, 13);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(82, 51);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Letter Shift";
            // 
            // shiftLetter
            // 
            shiftLetter.Location = new Point(6, 21);
            shiftLetter.Name = "shiftLetter";
            shiftLetter.Size = new Size(70, 23);
            shiftLetter.TabIndex = 0;
            // 
            // keyChar
            // 
            keyChar.AutoSize = true;
            keyChar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            keyChar.Location = new Point(280, 28);
            keyChar.Name = "keyChar";
            keyChar.Size = new Size(25, 25);
            keyChar.TabIndex = 6;
            keyChar.Text = "A";
            keyChar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(246, 70);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(59, 23);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonCopy
            // 
            buttonCopy.AutoSize = true;
            buttonCopy.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCopy.Location = new Point(311, 32);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(91, 25);
            buttonCopy.TabIndex = 9;
            buttonCopy.Text = "Copy This Key";
            buttonCopy.TextAlign = ContentAlignment.MiddleLeft;
            buttonCopy.UseVisualStyleBackColor = true;
            // 
            // MainAnalyzer
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1050, 658);
            Controls.Add(buttonCopy);
            Controls.Add(buttonReset);
            Controls.Add(keyChar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(keyInput);
            Name = "MainAnalyzer";
            Text = "Analysis Results";
            ((System.ComponentModel.ISupportInitialize)keyLength).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)selectLetter).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)shiftLetter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox keyInput;
        private GroupBox groupBox1;
        private NumericUpDown keyLength;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private NumericUpDown selectLetter;
        private GroupBox groupBox4;
        private NumericUpDown shiftLetter;
        private Label keyChar;
        private Button buttonReset;

        private StringBuilder key = new StringBuilder("Aa");
        private Button buttonCopy;
    }
}