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
            this.components = new System.ComponentModel.Container();
            this.SimulationTimerClock = new System.Windows.Forms.Timer(this.components);
            this.PictureBoxGrid = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeadPersosnLabel = new System.Windows.Forms.Label();
            this.DeadPersonsText = new System.Windows.Forms.Label();
            this.GreenPersonsText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OrangePersonsText = new System.Windows.Forms.Label();
            this.RedPersonsText = new System.Windows.Forms.Label();
            this.YellowPersonsText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CountsPersons = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CountTurnLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SimulationTimerClock
            // 
            this.SimulationTimerClock.Interval = 200;
            this.SimulationTimerClock.Tick += new System.EventHandler(this.SimulationTimer);
            // 
            // PictureBoxGrid
            // 
            this.PictureBoxGrid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PictureBoxGrid.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxGrid.Name = "PictureBoxGrid";
            this.PictureBoxGrid.Size = new System.Drawing.Size(516, 516);
            this.PictureBoxGrid.TabIndex = 0;
            this.PictureBoxGrid.TabStop = false;
            this.PictureBoxGrid.Visible = false;
            this.PictureBoxGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBox);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(540, 44);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 29);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartSimulation);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeadPersosnLabel);
            this.groupBox1.Controls.Add(this.DeadPersonsText);
            this.groupBox1.Controls.Add(this.GreenPersonsText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.OrangePersonsText);
            this.groupBox1.Controls.Add(this.RedPersonsText);
            this.groupBox1.Controls.Add(this.YellowPersonsText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CountsPersons);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(534, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statystyki";
            // 
            // DeadPersosnLabel
            // 
            this.DeadPersosnLabel.AutoSize = true;
            this.DeadPersosnLabel.Location = new System.Drawing.Point(109, 154);
            this.DeadPersosnLabel.Name = "DeadPersosnLabel";
            this.DeadPersosnLabel.Size = new System.Drawing.Size(17, 20);
            this.DeadPersosnLabel.TabIndex = 14;
            this.DeadPersosnLabel.Text = "0";
            // 
            // DeadPersonsText
            // 
            this.DeadPersonsText.AutoSize = true;
            this.DeadPersonsText.Location = new System.Drawing.Point(109, 134);
            this.DeadPersonsText.Name = "DeadPersonsText";
            this.DeadPersonsText.Size = new System.Drawing.Size(17, 20);
            this.DeadPersonsText.TabIndex = 13;
            this.DeadPersonsText.Text = "0";
            // 
            // GreenPersonsText
            // 
            this.GreenPersonsText.AutoSize = true;
            this.GreenPersonsText.Location = new System.Drawing.Point(119, 103);
            this.GreenPersonsText.Name = "GreenPersonsText";
            this.GreenPersonsText.Size = new System.Drawing.Size(17, 20);
            this.GreenPersonsText.TabIndex = 12;
            this.GreenPersonsText.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ilość zarażonych:";
            // 
            // OrangePersonsText
            // 
            this.OrangePersonsText.AutoSize = true;
            this.OrangePersonsText.Location = new System.Drawing.Point(152, 83);
            this.OrangePersonsText.Name = "OrangePersonsText";
            this.OrangePersonsText.Size = new System.Drawing.Size(17, 20);
            this.OrangePersonsText.TabIndex = 11;
            this.OrangePersonsText.Text = "0";
            // 
            // RedPersonsText
            // 
            this.RedPersonsText.AutoSize = true;
            this.RedPersonsText.Location = new System.Drawing.Point(109, 63);
            this.RedPersonsText.Name = "RedPersonsText";
            this.RedPersonsText.Size = new System.Drawing.Size(17, 20);
            this.RedPersonsText.TabIndex = 10;
            this.RedPersonsText.Text = "0";
            // 
            // YellowPersonsText
            // 
            this.YellowPersonsText.AutoSize = true;
            this.YellowPersonsText.Location = new System.Drawing.Point(130, 43);
            this.YellowPersonsText.Name = "YellowPersonsText";
            this.YellowPersonsText.Size = new System.Drawing.Size(17, 20);
            this.YellowPersonsText.TabIndex = 9;
            this.YellowPersonsText.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ilość zdrowych:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ilość zdrowiejących:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ilość chorych:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ilość narodzin:";
            // 
            // CountsPersons
            // 
            this.CountsPersons.AutoSize = true;
            this.CountsPersons.Location = new System.Drawing.Point(129, 23);
            this.CountsPersons.Name = "CountsPersons";
            this.CountsPersons.Size = new System.Drawing.Size(17, 20);
            this.CountsPersons.TabIndex = 3;
            this.CountsPersons.Text = "0";
            this.CountsPersons.Click += new System.EventHandler(this.CountsPersons_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ilość zmarłych:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ilość osobników:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(581, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 3;
            this.label8.Text = "Liczba tur:";
            // 
            // CountTurnLabel
            // 
            this.CountTurnLabel.AutoSize = true;
            this.CountTurnLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountTurnLabel.Location = new System.Drawing.Point(687, 500);
            this.CountTurnLabel.Name = "CountTurnLabel";
            this.CountTurnLabel.Size = new System.Drawing.Size(23, 28);
            this.CountTurnLabel.TabIndex = 4;
            this.CountTurnLabel.Text = "0";
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(653, 44);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(94, 29);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 543);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.CountTurnLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PictureBoxGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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