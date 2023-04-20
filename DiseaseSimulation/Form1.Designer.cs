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
            deadPersonCountByAge = new Label();
            DeadPersonsCount = new Label();
            BornPersonsCount = new Label();
            deadPersonCounByDisease = new Label();
            label3 = new Label();
            CountsPersons = new Label();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            YellowPersonsText = new Label();
            label7 = new Label();
            RedPersonsText = new Label();
            GreenPersonsText = new Label();
            OrangePersonsText = new Label();
            label4 = new Label();
            label5 = new Label();
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
            SimulationTimerClock.Tick += SimulationTimerTurn;
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
            StartButton.Location = new Point(536, 9);
            StartButton.Margin = new Padding(3, 2, 3, 2);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(82, 22);
            StartButton.TabIndex = 1;
            StartButton.Text = "Resume";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartSimulationButton;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deadPersonCountByAge);
            groupBox1.Controls.Add(DeadPersonsCount);
            groupBox1.Controls.Add(BornPersonsCount);
            groupBox1.Controls.Add(deadPersonCounByDisease);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(CountsPersons);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(YellowPersonsText);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(RedPersonsText);
            groupBox1.Controls.Add(GreenPersonsText);
            groupBox1.Controls.Add(OrangePersonsText);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(536, 168);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(186, 188);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statystyki";
            // 
            // deadPersonCountByAge
            // 
            deadPersonCountByAge.AutoSize = true;
            deadPersonCountByAge.Location = new Point(131, 164);
            deadPersonCountByAge.Name = "deadPersonCountByAge";
            deadPersonCountByAge.Size = new Size(13, 15);
            deadPersonCountByAge.TabIndex = 18;
            deadPersonCountByAge.Text = "0";
            // 
            // DeadPersonsCount
            // 
            DeadPersonsCount.AutoSize = true;
            DeadPersonsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeadPersonsCount.Location = new Point(138, 134);
            DeadPersonsCount.Name = "DeadPersonsCount";
            DeadPersonsCount.Size = new Size(14, 15);
            DeadPersonsCount.TabIndex = 14;
            DeadPersonsCount.Text = "0";
            // 
            // BornPersonsCount
            // 
            BornPersonsCount.AutoSize = true;
            BornPersonsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BornPersonsCount.Location = new Point(138, 108);
            BornPersonsCount.Name = "BornPersonsCount";
            BornPersonsCount.Size = new Size(14, 15);
            BornPersonsCount.TabIndex = 13;
            BornPersonsCount.Text = "0";
            // 
            // deadPersonCounByDisease
            // 
            deadPersonCounByDisease.AutoSize = true;
            deadPersonCounByDisease.Location = new Point(131, 149);
            deadPersonCounByDisease.Name = "deadPersonCounByDisease";
            deadPersonCounByDisease.Size = new Size(13, 15);
            deadPersonCounByDisease.TabIndex = 17;
            deadPersonCounByDisease.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 108);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 4;
            label3.Text = "Ilość narodzin:";
            // 
            // CountsPersons
            // 
            CountsPersons.AutoSize = true;
            CountsPersons.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CountsPersons.Location = new Point(138, 21);
            CountsPersons.Name = "CountsPersons";
            CountsPersons.Size = new Size(14, 15);
            CountsPersons.TabIndex = 3;
            CountsPersons.Text = "0";
            CountsPersons.Click += CountsPersons_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 149);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 16;
            label10.Text = "przez chorobę:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 164);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 15;
            label9.Text = "przez wiek:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 134);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 2;
            label2.Text = "Ilość zmarłych:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 21);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Ilość osobników:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 69);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 7;
            label6.Text = "Ilość zdrowiejących:";
            // 
            // YellowPersonsText
            // 
            YellowPersonsText.AutoSize = true;
            YellowPersonsText.Location = new Point(127, 39);
            YellowPersonsText.Name = "YellowPersonsText";
            YellowPersonsText.Size = new Size(13, 15);
            YellowPersonsText.TabIndex = 9;
            YellowPersonsText.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 84);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 8;
            label7.Text = "Ilość zdrowych:";
            // 
            // RedPersonsText
            // 
            RedPersonsText.AutoSize = true;
            RedPersonsText.Location = new Point(127, 54);
            RedPersonsText.Name = "RedPersonsText";
            RedPersonsText.Size = new Size(13, 15);
            RedPersonsText.TabIndex = 10;
            RedPersonsText.Text = "0";
            // 
            // GreenPersonsText
            // 
            GreenPersonsText.AutoSize = true;
            GreenPersonsText.Location = new Point(127, 84);
            GreenPersonsText.Name = "GreenPersonsText";
            GreenPersonsText.Size = new Size(13, 15);
            GreenPersonsText.TabIndex = 12;
            GreenPersonsText.Text = "0";
            // 
            // OrangePersonsText
            // 
            OrangePersonsText.AutoSize = true;
            OrangePersonsText.Location = new Point(127, 69);
            OrangePersonsText.Name = "OrangePersonsText";
            OrangePersonsText.Size = new Size(13, 15);
            OrangePersonsText.TabIndex = 11;
            OrangePersonsText.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 39);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 5;
            label4.Text = "Ilość zarażonych:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 54);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 6;
            label5.Text = "Ilość chorych:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(572, 42);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 3;
            label8.Text = "Liczba tur:";
            // 
            // CountTurnLabel
            // 
            CountTurnLabel.AutoSize = true;
            CountTurnLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CountTurnLabel.Location = new Point(665, 42);
            CountTurnLabel.Name = "CountTurnLabel";
            CountTurnLabel.Size = new Size(19, 21);
            CountTurnLabel.TabIndex = 4;
            CountTurnLabel.Text = "0";
            // 
            // StopButton
            // 
            StopButton.Enabled = false;
            StopButton.Location = new Point(635, 9);
            StopButton.Margin = new Padding(3, 2, 3, 2);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(82, 22);
            StopButton.TabIndex = 5;
            StopButton.Text = "Pause";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += PauseSimulationButton;
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
        private Label DeadPersonsCount;
        private Label BornPersonsCount;
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
        private Label deadPersonCountByAge;
        private Label deadPersonCounByDisease;
        private Label label10;
        private Label label9;
    }
}