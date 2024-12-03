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
            groupBox5 = new GroupBox();
            label17 = new Label();
            progressBar17 = new ProgressBar();
            label18 = new Label();
            progressBar18 = new ProgressBar();
            label19 = new Label();
            progressBar19 = new ProgressBar();
            label20 = new Label();
            progressBar20 = new ProgressBar();
            label21 = new Label();
            progressBar21 = new ProgressBar();
            label22 = new Label();
            progressBar22 = new ProgressBar();
            label23 = new Label();
            progressBar23 = new ProgressBar();
            label24 = new Label();
            progressBar24 = new ProgressBar();
            label25 = new Label();
            progressBar25 = new ProgressBar();
            label26 = new Label();
            progressBar26 = new ProgressBar();
            label9 = new Label();
            progressBar9 = new ProgressBar();
            label10 = new Label();
            progressBar10 = new ProgressBar();
            label11 = new Label();
            progressBar11 = new ProgressBar();
            label12 = new Label();
            progressBar12 = new ProgressBar();
            label13 = new Label();
            progressBar13 = new ProgressBar();
            label14 = new Label();
            progressBar14 = new ProgressBar();
            label15 = new Label();
            progressBar15 = new ProgressBar();
            label16 = new Label();
            progressBar16 = new ProgressBar();
            label5 = new Label();
            progressBar5 = new ProgressBar();
            label6 = new Label();
            progressBar6 = new ProgressBar();
            label7 = new Label();
            progressBar7 = new ProgressBar();
            label8 = new Label();
            progressBar8 = new ProgressBar();
            label3 = new Label();
            progressBar3 = new ProgressBar();
            label4 = new Label();
            progressBar4 = new ProgressBar();
            label2 = new Label();
            progressBar2 = new ProgressBar();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            keyLength = new NumericUpDown();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            selectLetter = new NumericUpDown();
            groupBox4 = new GroupBox();
            shiftLetter = new NumericUpDown();
            keyChar = new Label();
            buttonReset = new Button();
            buttonCopy = new Button();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
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
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Location = new Point(13, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1026, 513);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Analysis Results";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(progressBar17);
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(progressBar18);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(progressBar19);
            groupBox5.Controls.Add(label20);
            groupBox5.Controls.Add(progressBar20);
            groupBox5.Controls.Add(label21);
            groupBox5.Controls.Add(progressBar21);
            groupBox5.Controls.Add(label22);
            groupBox5.Controls.Add(progressBar22);
            groupBox5.Controls.Add(label23);
            groupBox5.Controls.Add(progressBar23);
            groupBox5.Controls.Add(label24);
            groupBox5.Controls.Add(progressBar24);
            groupBox5.Controls.Add(label25);
            groupBox5.Controls.Add(progressBar25);
            groupBox5.Controls.Add(label26);
            groupBox5.Controls.Add(progressBar26);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(progressBar9);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(progressBar10);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(progressBar11);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(progressBar12);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(progressBar13);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(progressBar14);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(progressBar15);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(progressBar16);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(progressBar5);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(progressBar6);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(progressBar7);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(progressBar8);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(progressBar3);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(progressBar4);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(progressBar2);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(progressBar1);
            groupBox5.Location = new Point(6, 22);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(351, 485);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "English Letter Frequency";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label17.Location = new Point(6, 432);
            label17.Name = "label17";
            label17.Size = new Size(14, 15);
            label17.TabIndex = 51;
            label17.Text = "Z";
            // 
            // progressBar17
            // 
            progressBar17.Location = new Point(27, 431);
            progressBar17.Maximum = 127;
            progressBar17.Name = "progressBar17";
            progressBar17.Size = new Size(311, 10);
            progressBar17.Step = 1;
            progressBar17.TabIndex = 50;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label18.Location = new Point(6, 416);
            label18.Name = "label18";
            label18.Size = new Size(14, 15);
            label18.TabIndex = 49;
            label18.Text = "Y";
            // 
            // progressBar18
            // 
            progressBar18.Location = new Point(27, 415);
            progressBar18.Maximum = 127;
            progressBar18.Name = "progressBar18";
            progressBar18.Size = new Size(311, 10);
            progressBar18.Step = 1;
            progressBar18.TabIndex = 48;
            progressBar18.Value = 2;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label19.Location = new Point(6, 400);
            label19.Name = "label19";
            label19.Size = new Size(15, 15);
            label19.TabIndex = 47;
            label19.Text = "X";
            // 
            // progressBar19
            // 
            progressBar19.Location = new Point(27, 399);
            progressBar19.Maximum = 127;
            progressBar19.Name = "progressBar19";
            progressBar19.Size = new Size(311, 10);
            progressBar19.Step = 1;
            progressBar19.TabIndex = 46;
            progressBar19.Value = 1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label20.Location = new Point(6, 384);
            label20.Name = "label20";
            label20.Size = new Size(19, 15);
            label20.TabIndex = 45;
            label20.Text = "W";
            // 
            // progressBar20
            // 
            progressBar20.Location = new Point(27, 383);
            progressBar20.Maximum = 127;
            progressBar20.Name = "progressBar20";
            progressBar20.Size = new Size(311, 10);
            progressBar20.Step = 1;
            progressBar20.TabIndex = 44;
            progressBar20.Value = 24;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label21.Location = new Point(6, 368);
            label21.Name = "label21";
            label21.Size = new Size(15, 15);
            label21.TabIndex = 43;
            label21.Text = "V";
            // 
            // progressBar21
            // 
            progressBar21.Location = new Point(27, 367);
            progressBar21.Maximum = 127;
            progressBar21.Name = "progressBar21";
            progressBar21.Size = new Size(311, 10);
            progressBar21.Step = 1;
            progressBar21.TabIndex = 42;
            progressBar21.Value = 10;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label22.Location = new Point(6, 352);
            label22.Name = "label22";
            label22.Size = new Size(16, 15);
            label22.TabIndex = 41;
            label22.Text = "U";
            // 
            // progressBar22
            // 
            progressBar22.Location = new Point(27, 351);
            progressBar22.Maximum = 127;
            progressBar22.Name = "progressBar22";
            progressBar22.Size = new Size(311, 10);
            progressBar22.Step = 1;
            progressBar22.TabIndex = 40;
            progressBar22.Value = 28;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label23.Location = new Point(6, 336);
            label23.Name = "label23";
            label23.Size = new Size(14, 15);
            label23.TabIndex = 39;
            label23.Text = "T";
            // 
            // progressBar23
            // 
            progressBar23.Location = new Point(27, 335);
            progressBar23.Maximum = 127;
            progressBar23.Name = "progressBar23";
            progressBar23.Size = new Size(311, 10);
            progressBar23.Step = 1;
            progressBar23.TabIndex = 38;
            progressBar23.Value = 91;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label24.Location = new Point(6, 320);
            label24.Name = "label24";
            label24.Size = new Size(14, 15);
            label24.TabIndex = 37;
            label24.Text = "S";
            // 
            // progressBar24
            // 
            progressBar24.Location = new Point(27, 319);
            progressBar24.Maximum = 127;
            progressBar24.Name = "progressBar24";
            progressBar24.Size = new Size(311, 10);
            progressBar24.Step = 1;
            progressBar24.TabIndex = 36;
            progressBar24.Value = 63;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label25.Location = new Point(6, 304);
            label25.Name = "label25";
            label25.Size = new Size(15, 15);
            label25.TabIndex = 35;
            label25.Text = "R";
            // 
            // progressBar25
            // 
            progressBar25.Location = new Point(27, 303);
            progressBar25.Maximum = 127;
            progressBar25.Name = "progressBar25";
            progressBar25.Size = new Size(311, 10);
            progressBar25.Step = 1;
            progressBar25.TabIndex = 34;
            progressBar25.Value = 60;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label26.Location = new Point(6, 288);
            label26.Name = "label26";
            label26.Size = new Size(16, 15);
            label26.TabIndex = 33;
            label26.Text = "Q";
            // 
            // progressBar26
            // 
            progressBar26.Location = new Point(27, 287);
            progressBar26.Maximum = 127;
            progressBar26.Name = "progressBar26";
            progressBar26.Size = new Size(311, 10);
            progressBar26.Step = 1;
            progressBar26.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(6, 272);
            label9.Name = "label9";
            label9.Size = new Size(14, 15);
            label9.TabIndex = 31;
            label9.Text = "P";
            // 
            // progressBar9
            // 
            progressBar9.Location = new Point(27, 271);
            progressBar9.Maximum = 127;
            progressBar9.Name = "progressBar9";
            progressBar9.Size = new Size(311, 10);
            progressBar9.Step = 1;
            progressBar9.TabIndex = 30;
            progressBar9.Value = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(6, 256);
            label10.Name = "label10";
            label10.Size = new Size(16, 15);
            label10.TabIndex = 29;
            label10.Text = "O";
            // 
            // progressBar10
            // 
            progressBar10.Location = new Point(27, 255);
            progressBar10.Maximum = 127;
            progressBar10.Name = "progressBar10";
            progressBar10.Size = new Size(311, 10);
            progressBar10.Step = 1;
            progressBar10.TabIndex = 28;
            progressBar10.Value = 75;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(6, 240);
            label11.Name = "label11";
            label11.Size = new Size(16, 15);
            label11.TabIndex = 27;
            label11.Text = "N";
            // 
            // progressBar11
            // 
            progressBar11.Location = new Point(27, 239);
            progressBar11.Maximum = 127;
            progressBar11.Name = "progressBar11";
            progressBar11.Size = new Size(311, 10);
            progressBar11.Step = 1;
            progressBar11.TabIndex = 26;
            progressBar11.Value = 67;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.Location = new Point(6, 224);
            label12.Name = "label12";
            label12.Size = new Size(18, 15);
            label12.TabIndex = 25;
            label12.Text = "M";
            // 
            // progressBar12
            // 
            progressBar12.Location = new Point(27, 223);
            progressBar12.Maximum = 127;
            progressBar12.Name = "progressBar12";
            progressBar12.Size = new Size(311, 10);
            progressBar12.Step = 1;
            progressBar12.TabIndex = 24;
            progressBar12.Value = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(6, 208);
            label13.Name = "label13";
            label13.Size = new Size(13, 15);
            label13.TabIndex = 23;
            label13.Text = "L";
            // 
            // progressBar13
            // 
            progressBar13.Location = new Point(27, 207);
            progressBar13.Maximum = 127;
            progressBar13.Name = "progressBar13";
            progressBar13.Size = new Size(311, 10);
            progressBar13.Step = 1;
            progressBar13.TabIndex = 22;
            progressBar13.Value = 40;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(6, 192);
            label14.Name = "label14";
            label14.Size = new Size(15, 15);
            label14.TabIndex = 21;
            label14.Text = "K";
            // 
            // progressBar14
            // 
            progressBar14.Location = new Point(27, 191);
            progressBar14.Maximum = 127;
            progressBar14.Name = "progressBar14";
            progressBar14.Size = new Size(311, 10);
            progressBar14.Step = 1;
            progressBar14.TabIndex = 20;
            progressBar14.Value = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label15.Location = new Point(6, 176);
            label15.Name = "label15";
            label15.Size = new Size(12, 15);
            label15.TabIndex = 19;
            label15.Text = "J";
            // 
            // progressBar15
            // 
            progressBar15.Location = new Point(27, 175);
            progressBar15.Maximum = 127;
            progressBar15.Name = "progressBar15";
            progressBar15.Size = new Size(311, 10);
            progressBar15.Step = 1;
            progressBar15.TabIndex = 18;
            progressBar15.Value = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label16.Location = new Point(6, 160);
            label16.Name = "label16";
            label16.Size = new Size(11, 15);
            label16.TabIndex = 17;
            label16.Text = "I";
            // 
            // progressBar16
            // 
            progressBar16.Location = new Point(27, 159);
            progressBar16.Maximum = 127;
            progressBar16.Name = "progressBar16";
            progressBar16.Size = new Size(311, 10);
            progressBar16.Step = 1;
            progressBar16.TabIndex = 16;
            progressBar16.Value = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(6, 144);
            label5.Name = "label5";
            label5.Size = new Size(16, 15);
            label5.TabIndex = 15;
            label5.Text = "H";
            // 
            // progressBar5
            // 
            progressBar5.Location = new Point(27, 143);
            progressBar5.Maximum = 127;
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(311, 10);
            progressBar5.Step = 1;
            progressBar5.TabIndex = 14;
            progressBar5.Value = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(6, 128);
            label6.Name = "label6";
            label6.Size = new Size(16, 15);
            label6.TabIndex = 13;
            label6.Text = "G";
            // 
            // progressBar6
            // 
            progressBar6.Location = new Point(27, 127);
            progressBar6.Maximum = 127;
            progressBar6.Name = "progressBar6";
            progressBar6.Size = new Size(311, 10);
            progressBar6.Step = 1;
            progressBar6.TabIndex = 12;
            progressBar6.Value = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(6, 112);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 11;
            label7.Text = "F";
            // 
            // progressBar7
            // 
            progressBar7.Location = new Point(27, 111);
            progressBar7.Maximum = 127;
            progressBar7.Name = "progressBar7";
            progressBar7.Size = new Size(311, 10);
            progressBar7.Step = 1;
            progressBar7.TabIndex = 10;
            progressBar7.Value = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(6, 96);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 9;
            label8.Text = "E";
            // 
            // progressBar8
            // 
            progressBar8.Location = new Point(27, 95);
            progressBar8.Maximum = 127;
            progressBar8.Name = "progressBar8";
            progressBar8.Size = new Size(311, 10);
            progressBar8.Step = 1;
            progressBar8.TabIndex = 8;
            progressBar8.Value = 127;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 80);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 7;
            label3.Text = "D";
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(27, 79);
            progressBar3.Maximum = 127;
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(311, 10);
            progressBar3.Step = 1;
            progressBar3.TabIndex = 6;
            progressBar3.Value = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 64);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 5;
            label4.Text = "C";
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(27, 63);
            progressBar4.Maximum = 127;
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(311, 10);
            progressBar4.Step = 1;
            progressBar4.TabIndex = 4;
            progressBar4.Value = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 3;
            label2.Text = "B";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(27, 47);
            progressBar2.Maximum = 127;
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(311, 10);
            progressBar2.Step = 1;
            progressBar2.TabIndex = 2;
            progressBar2.Value = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 1;
            label1.Text = "A";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(27, 31);
            progressBar1.Maximum = 127;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(311, 10);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 0;
            progressBar1.Value = 82;
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
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
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

        public static TextBox keyInput;
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
        private ProgressBar progressBar1;
        private GroupBox groupBox5;
        private Label label9;
        private ProgressBar progressBar9;
        private Label label10;
        private ProgressBar progressBar10;
        private Label label11;
        private ProgressBar progressBar11;
        private Label label12;
        private ProgressBar progressBar12;
        private Label label13;
        private ProgressBar progressBar13;
        private Label label14;
        private ProgressBar progressBar14;
        private Label label15;
        private ProgressBar progressBar15;
        private Label label16;
        private ProgressBar progressBar16;
        private Label label5;
        private ProgressBar progressBar5;
        private Label label6;
        private ProgressBar progressBar6;
        private Label label7;
        private ProgressBar progressBar7;
        private Label label8;
        private ProgressBar progressBar8;
        private Label label3;
        private ProgressBar progressBar3;
        private Label label4;
        private ProgressBar progressBar4;
        private Label label2;
        private ProgressBar progressBar2;
        private Label label1;
        private Label label17;
        private ProgressBar progressBar17;
        private Label label18;
        private ProgressBar progressBar18;
        private Label label19;
        private ProgressBar progressBar19;
        private Label label20;
        private ProgressBar progressBar20;
        private Label label21;
        private ProgressBar progressBar21;
        private Label label22;
        private ProgressBar progressBar22;
        private Label label23;
        private ProgressBar progressBar23;
        private Label label24;
        private ProgressBar progressBar24;
        private Label label25;
        private ProgressBar progressBar25;
        private Label label26;
        private ProgressBar progressBar26;
    }
}