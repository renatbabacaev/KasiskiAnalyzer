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
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            groupBox4 = new GroupBox();
            numericUpDown3 = new NumericUpDown();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 70);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Key...";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 0;
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 22);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(69, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(81, 52);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Key Length";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numericUpDown2);
            groupBox3.Location = new Point(99, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(87, 52);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Select Letter";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(6, 22);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(75, 23);
            numericUpDown2.TabIndex = 0;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(numericUpDown3);
            groupBox4.Location = new Point(192, 13);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(82, 51);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Letter Shift";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(6, 21);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(70, 23);
            numericUpDown3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(280, 28);
            label1.Name = "label1";
            label1.Size = new Size(25, 25);
            label1.TabIndex = 6;
            label1.Text = "A";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(246, 70);
            button1.Name = "button1";
            button1.Size = new Size(59, 23);
            button1.TabIndex = 7;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainAnalyzer
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1050, 658);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Name = "MainAnalyzer";
            Text = "Analysis Results";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private NumericUpDown numericUpDown2;
        private GroupBox groupBox4;
        private NumericUpDown numericUpDown3;
        private Label label1;
        private Button button1;
    }
}