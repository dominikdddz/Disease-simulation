namespace DiseaseSimulation
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
            SimulationTimerClock = new System.Windows.Forms.Timer(components);
            PictureBoxGrid = new PictureBox();
            StartButton = new Button();
            groupBox1 = new GroupBox();
            DeadPersosnLabel = new Label();
            DeadPersonsText = new Label();
            GreenPersonsText = new Label();
            label4 = new Label();
            OrangePersonsText = new Label();
            RedPersonsText = new Label();
            YellowPersonsText = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            CountsPersons = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            CountTurnLabel = new Label();
            StopButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBoxGrid).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SimulationTimerClock
            // 
            SimulationTimerClock.Interval = 200;
            SimulationTimerClock.Tick += SimulationTimer;
            // 
            // PictureBoxGrid
            // 
            PictureBoxGrid.BackColor = SystemColors.ControlLight;
            PictureBoxGrid.Location = new Point(10, 9);
            PictureBoxGrid.Margin = new Padding(3, 2, 3, 2);
            PictureBoxGrid.Name = "PictureBoxGrid";
            PictureBoxGrid.Size = new Size(516, 516);
            PictureBoxGrid.TabIndex = 0;
            PictureBoxGrid.TabStop = false;
            PictureBoxGrid.Visible = false;
            PictureBoxGrid.Paint += UpdatePictureBox;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(538, 34);
            StartButton.Margin = new Padding(3, 2, 3, 2);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(82, 22);
            StartButton.TabIndex = 1;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartSimulation;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DeadPersosnLabel);
            groupBox1.Controls.Add(DeadPersonsText);
            groupBox1.Controls.Add(GreenPersonsText);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(OrangePersonsText);
            groupBox1.Controls.Add(RedPersonsText);
            groupBox1.Controls.Add(YellowPersonsText);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(CountsPersons);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(533, 79);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(186, 136);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statystyki";
            // 
            // DeadPersosnLabel
            // 
            DeadPersosnLabel.AutoSize = true;
            DeadPersosnLabel.Location = new Point(95, 116);
            DeadPersosnLabel.Name = "DeadPersosnLabel";
            DeadPersosnLabel.Size = new Size(13, 15);
            DeadPersosnLabel.TabIndex = 14;
            DeadPersosnLabel.Text = "0";
            // 
            // DeadPersonsText
            // 
            DeadPersonsText.AutoSize = true;
            DeadPersonsText.Location = new Point(95, 100);
            DeadPersonsText.Name = "DeadPersonsText";
            DeadPersonsText.Size = new Size(13, 15);
            DeadPersonsText.TabIndex = 13;
            DeadPersonsText.Text = "0";
            // 
            // GreenPersonsText
            // 
            GreenPersonsText.AutoSize = true;
            GreenPersonsText.Location = new Point(104, 77);
            GreenPersonsText.Name = "GreenPersonsText";
            GreenPersonsText.Size = new Size(13, 15);
            GreenPersonsText.TabIndex = 12;
            GreenPersonsText.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 32);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 5;
            label4.Text = "Ilość zarażonych:";
            // 
            // OrangePersonsText
            // 
            OrangePersonsText.AutoSize = true;
            OrangePersonsText.Location = new Point(133, 62);
            OrangePersonsText.Name = "OrangePersonsText";
            OrangePersonsText.Size = new Size(13, 15);
            OrangePersonsText.TabIndex = 11;
            OrangePersonsText.Text = "0";
            // 
            // RedPersonsText
            // 
            RedPersonsText.AutoSize = true;
            RedPersonsText.Location = new Point(95, 47);
            RedPersonsText.Name = "RedPersonsText";
            RedPersonsText.Size = new Size(13, 15);
            RedPersonsText.TabIndex = 10;
            RedPersonsText.Text = "0";
            // 
            // YellowPersonsText
            // 
            YellowPersonsText.AutoSize = true;
            YellowPersonsText.Location = new Point(114, 32);
            YellowPersonsText.Name = "YellowPersonsText";
            YellowPersonsText.Size = new Size(13, 15);
            YellowPersonsText.TabIndex = 9;
            YellowPersonsText.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 77);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 8;
            label7.Text = "Ilość zdrowych:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 62);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 7;
            label6.Text = "Ilość zdrowiejących:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 47);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 6;
            label5.Text = "Ilość chorych:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 100);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 4;
            label3.Text = "Ilość narodzin:";
            // 
            // CountsPersons
            // 
            CountsPersons.AutoSize = true;
            CountsPersons.Location = new Point(113, 17);
            CountsPersons.Name = "CountsPersons";
            CountsPersons.Size = new Size(13, 15);
            CountsPersons.TabIndex = 3;
            CountsPersons.Text = "0";
            CountsPersons.Click += CountsPersons_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 116);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 2;
            label2.Text = "Ilość zmarłych:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 17);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Ilość osobników:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(561, 504);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 3;
            label8.Text = "Liczba tur:";
            // 
            // CountTurnLabel
            // 
            CountTurnLabel.AutoSize = true;
            CountTurnLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CountTurnLabel.Location = new Point(654, 504);
            CountTurnLabel.Name = "CountTurnLabel";
            CountTurnLabel.Size = new Size(19, 21);
            CountTurnLabel.TabIndex = 4;
            CountTurnLabel.Text = "0";
            // 
            // StopButton
            // 
            StopButton.Enabled = false;
            StopButton.Location = new Point(637, 34);
            StopButton.Margin = new Padding(3, 2, 3, 2);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(82, 22);
            StopButton.TabIndex = 5;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 537);
            Controls.Add(StopButton);
            Controls.Add(CountTurnLabel);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(StartButton);
            Controls.Add(PictureBoxGrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Disease Simulation";
            ((System.ComponentModel.ISupportInitialize)PictureBoxGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PictureBoxGrid;
        private System.Windows.Forms.Timer SimulationTimerClock;
        private Button StartButton;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label DeadPersosnLabel;
        private Label DeadPersonsText;
        private Label GreenPersonsText;
        private Label OrangePersonsText;
        private Label RedPersonsText;
        private Label YellowPersonsText;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label CountsPersons;
        private Label label8;
        private Label CountTurnLabel;
        private Button StopButton;
    }
}