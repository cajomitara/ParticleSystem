namespace ParticleSystem
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            picDisplay = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            tbDirection = new TrackBar();
            lblDirection = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            tbTeleportSize = new TrackBar();
            button1 = new Button();
            tbRadarSize = new TrackBar();
            label3 = new Label();
            label4 = new Label();
            pbRed = new PictureBox();
            pbGreen = new PictureBox();
            pbBlue = new PictureBox();
            pbOrange = new PictureBox();
            pbGrey = new PictureBox();
            pbPink = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbTeleportSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbRadarSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGrey).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPink).BeginInit();
            SuspendLayout();
            // 
            // picDisplay
            // 
            picDisplay.Location = new Point(12, 12);
            picDisplay.Name = "picDisplay";
            picDisplay.Size = new Size(885, 684);
            picDisplay.TabIndex = 0;
            picDisplay.TabStop = false;
            picDisplay.MouseClick += picDisplay_MouseClick;
            picDisplay.MouseMove += picDisplay_MouseMove;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // tbDirection
            // 
            tbDirection.Location = new Point(942, 33);
            tbDirection.Maximum = 359;
            tbDirection.Name = "tbDirection";
            tbDirection.Size = new Size(164, 56);
            tbDirection.TabIndex = 1;
            tbDirection.Scroll += tbDirection_Scroll;
            // 
            // lblDirection
            // 
            lblDirection.AutoSize = true;
            lblDirection.Location = new Point(1011, 69);
            lblDirection.Name = "lblDirection";
            lblDirection.Size = new Size(23, 20);
            lblDirection.TabIndex = 2;
            lblDirection.Text = "0°";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(952, 161);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 3;
            label1.Text = "Размеры порталов";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Телепорты", "Точка-счётчик", "Области отскока", "Радар" });
            comboBox1.Location = new Point(942, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(918, 92);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 3;
            label2.Text = "Выбор текущего объекта:";
            // 
            // tbTeleportSize
            // 
            tbTeleportSize.Location = new Point(940, 184);
            tbTeleportSize.Maximum = 200;
            tbTeleportSize.Minimum = 1;
            tbTeleportSize.Name = "tbTeleportSize";
            tbTeleportSize.Size = new Size(164, 56);
            tbTeleportSize.TabIndex = 1;
            tbTeleportSize.Value = 1;
            tbTeleportSize.Scroll += tbTeleportSize_Scroll;
            // 
            // button1
            // 
            button1.Location = new Point(903, 637);
            button1.Name = "button1";
            button1.Size = new Size(246, 59);
            button1.TabIndex = 6;
            button1.Text = "Очистить форму";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbRadarSize
            // 
            tbRadarSize.Location = new Point(942, 268);
            tbRadarSize.Maximum = 200;
            tbRadarSize.Minimum = 1;
            tbRadarSize.Name = "tbRadarSize";
            tbRadarSize.Size = new Size(164, 56);
            tbRadarSize.TabIndex = 1;
            tbRadarSize.Value = 1;
            tbRadarSize.Scroll += tbRadarSize_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(970, 327);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 3;
            label3.Text = "Цвет радара";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(940, 10);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 3;
            label4.Text = "Направление потока";
            // 
            // pbRed
            // 
            pbRed.BackColor = Color.Red;
            pbRed.BorderStyle = BorderStyle.FixedSingle;
            pbRed.Location = new Point(918, 356);
            pbRed.Name = "pbRed";
            pbRed.Size = new Size(50, 50);
            pbRed.TabIndex = 7;
            pbRed.TabStop = false;
            pbRed.Click += pbRed_Click;
            // 
            // pbGreen
            // 
            pbGreen.BackColor = Color.Lime;
            pbGreen.BorderStyle = BorderStyle.FixedSingle;
            pbGreen.Location = new Point(997, 356);
            pbGreen.Name = "pbGreen";
            pbGreen.Size = new Size(50, 50);
            pbGreen.TabIndex = 7;
            pbGreen.TabStop = false;
            pbGreen.Click += pbGreen_Click;
            // 
            // pbBlue
            // 
            pbBlue.BackColor = Color.SkyBlue;
            pbBlue.BorderStyle = BorderStyle.FixedSingle;
            pbBlue.Location = new Point(1074, 356);
            pbBlue.Name = "pbBlue";
            pbBlue.Size = new Size(50, 50);
            pbBlue.TabIndex = 7;
            pbBlue.TabStop = false;
            pbBlue.Click += pbBlue_Click;
            // 
            // pbOrange
            // 
            pbOrange.BackColor = Color.Orange;
            pbOrange.BorderStyle = BorderStyle.FixedSingle;
            pbOrange.Location = new Point(1074, 429);
            pbOrange.Name = "pbOrange";
            pbOrange.Size = new Size(50, 50);
            pbOrange.TabIndex = 7;
            pbOrange.TabStop = false;
            pbOrange.Click += pbOrange_Click;
            // 
            // pbGrey
            // 
            pbGrey.BackColor = Color.DarkGray;
            pbGrey.BorderStyle = BorderStyle.FixedSingle;
            pbGrey.Location = new Point(997, 429);
            pbGrey.Name = "pbGrey";
            pbGrey.Size = new Size(50, 50);
            pbGrey.TabIndex = 7;
            pbGrey.TabStop = false;
            pbGrey.Click += pbGrey_Click;
            // 
            // pbPink
            // 
            pbPink.BackColor = Color.DeepPink;
            pbPink.BorderStyle = BorderStyle.FixedSingle;
            pbPink.Location = new Point(918, 429);
            pbPink.Name = "pbPink";
            pbPink.Size = new Size(50, 50);
            pbPink.TabIndex = 7;
            pbPink.TabStop = false;
            pbPink.Click += pbPink_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(970, 243);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 3;
            label5.Text = "Размер радара";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 708);
            Controls.Add(pbPink);
            Controls.Add(pbGrey);
            Controls.Add(pbOrange);
            Controls.Add(pbBlue);
            Controls.Add(pbGreen);
            Controls.Add(pbRed);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblDirection);
            Controls.Add(tbRadarSize);
            Controls.Add(tbTeleportSize);
            Controls.Add(tbDirection);
            Controls.Add(picDisplay);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Система частиц";
            ((System.ComponentModel.ISupportInitialize)picDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbTeleportSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbRadarSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrange).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGrey).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPink).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private TrackBar tbDirection;
        private Label lblDirection;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TrackBar tbTeleportSize;
        private Button button1;
        private TrackBar tbRadarSize;
        private Label label3;
        private Label label4;
        private PictureBox pbRed;
        private PictureBox pbGreen;
        private PictureBox pbBlue;
        private PictureBox pbOrange;
        private PictureBox pbGrey;
        private PictureBox pbPink;
        private Label label5;
    }
}
