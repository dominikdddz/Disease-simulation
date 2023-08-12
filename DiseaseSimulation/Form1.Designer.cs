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
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            CountTurnLabel = new Label();
            label12 = new Label();
            deadPersonCountByAge = new Label();
            BornPersonsCount = new Label();
            labelCountBornPerson = new Label();
            CountsPersons = new Label();
            label1 = new Label();
            DeadPersonsCount = new Label();
            label8 = new Label();
            deadPersonCounByDisease = new Label();
            label4 = new Label();
            labelCountDeadByDisease = new Label();
            labelCountDeadByAge = new Label();
            label2 = new Label();
            label6 = new Label();
            YellowPersonsText = new Label();
            label7 = new Label();
            RedPersonsText = new Label();
            GreenPersonsText = new Label();
            OrangePersonsText = new Label();
            label5 = new Label();
            StopButton = new Button();
            label11 = new Label();
            radioButtonSick10p = new RadioButton();
            groupBox2 = new GroupBox();
            radioButtonSick50p = new RadioButton();
            radioButtonSick25p = new RadioButton();
            groupBox3 = new GroupBox();
            checkBoxBorn = new CheckBox();
            groupBoxInitialization = new GroupBox();
            groupBox5 = new GroupBox();
            radioBtnNPops = new RadioButton();
            textBoxNPersons = new TextBox();
            radioBtn1000Pops = new RadioButton();
            radioBtn100Pops = new RadioButton();
            buttonCreateSimulation = new Button();
            buttonSaveSimulation = new Button();
            buttonRestartSimulation = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBoxGrid).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBoxInitialization.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // SimulationTimerClock
            // 
            SimulationTimerClock.Tick += SimulationTimerTurn;
            // 
            // PictureBoxGrid
            // 
            PictureBoxGrid.BackColor = SystemColors.ControlLight;
            PictureBoxGrid.BorderStyle = BorderStyle.FixedSingle;
            PictureBoxGrid.Location = new Point(10, 10);
            PictureBoxGrid.Margin = new Padding(3, 2, 3, 2);
            PictureBoxGrid.Name = "PictureBoxGrid";
            PictureBoxGrid.Size = new Size(508, 508);
            PictureBoxGrid.TabIndex = 0;
            PictureBoxGrid.TabStop = false;
            PictureBoxGrid.Visible = false;
            PictureBoxGrid.Paint += UpdatePictureBox;
            PictureBoxGrid.MouseClick += pictureBoxGrid_MouseMove;
            // 
            // StartButton
            // 
            StartButton.Enabled = false;
            StartButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            StartButton.Location = new Point(607, 36);
            StartButton.Margin = new Padding(3, 2, 3, 2);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(71, 36);
            StartButton.TabIndex = 1;
            StartButton.Text = "Resume";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartSimulationButton;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(CountTurnLabel);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(deadPersonCountByAge);
            groupBox1.Controls.Add(BornPersonsCount);
            groupBox1.Controls.Add(labelCountBornPerson);
            groupBox1.Controls.Add(CountsPersons);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DeadPersonsCount);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(deadPersonCounByDisease);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelCountDeadByDisease);
            groupBox1.Controls.Add(labelCountDeadByAge);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(YellowPersonsText);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(RedPersonsText);
            groupBox1.Controls.Add(GreenPersonsText);
            groupBox1.Controls.Add(OrangePersonsText);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(536, 97);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(286, 232);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "STATYSTYKI";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Yellow;
            label15.Location = new Point(7, 51);
            label15.Name = "label15";
            label15.Size = new Size(26, 18);
            label15.TabIndex = 21;
            label15.Text = "⚫";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Orange;
            label14.Location = new Point(7, 87);
            label14.Name = "label14";
            label14.Size = new Size(26, 18);
            label14.TabIndex = 20;
            label14.Text = "⚫";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(7, 105);
            label13.Name = "label13";
            label13.Size = new Size(26, 18);
            label13.TabIndex = 19;
            label13.Text = "⚫";
            // 
            // CountTurnLabel
            // 
            CountTurnLabel.AutoSize = true;
            CountTurnLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CountTurnLabel.Location = new Point(259, 22);
            CountTurnLabel.Name = "CountTurnLabel";
            CountTurnLabel.Size = new Size(16, 18);
            CountTurnLabel.TabIndex = 4;
            CountTurnLabel.Tag = "";
            CountTurnLabel.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Green;
            label12.Location = new Point(7, 69);
            label12.Name = "label12";
            label12.Size = new Size(26, 18);
            label12.TabIndex = 9;
            label12.Text = "⚫";
            // 
            // deadPersonCountByAge
            // 
            deadPersonCountByAge.AutoSize = true;
            deadPersonCountByAge.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deadPersonCountByAge.Location = new Point(131, 170);
            deadPersonCountByAge.Name = "deadPersonCountByAge";
            deadPersonCountByAge.Size = new Size(16, 18);
            deadPersonCountByAge.TabIndex = 18;
            deadPersonCountByAge.Text = "0";
            // 
            // BornPersonsCount
            // 
            BornPersonsCount.AutoSize = true;
            BornPersonsCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BornPersonsCount.Location = new Point(121, 197);
            BornPersonsCount.Name = "BornPersonsCount";
            BornPersonsCount.Size = new Size(16, 18);
            BornPersonsCount.TabIndex = 13;
            BornPersonsCount.Text = "0";
            // 
            // labelCountBornPerson
            // 
            labelCountBornPerson.AutoSize = true;
            labelCountBornPerson.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCountBornPerson.Location = new Point(22, 197);
            labelCountBornPerson.Name = "labelCountBornPerson";
            labelCountBornPerson.Size = new Size(93, 18);
            labelCountBornPerson.TabIndex = 4;
            labelCountBornPerson.Text = "Urodzonych:";
            // 
            // CountsPersons
            // 
            CountsPersons.AutoSize = true;
            CountsPersons.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CountsPersons.Location = new Point(105, 22);
            CountsPersons.Name = "CountsPersons";
            CountsPersons.Size = new Size(16, 18);
            CountsPersons.TabIndex = 3;
            CountsPersons.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(75, 18);
            label1.TabIndex = 0;
            label1.Text = "Osobnicy:";
            // 
            // DeadPersonsCount
            // 
            DeadPersonsCount.AutoSize = true;
            DeadPersonsCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeadPersonsCount.Location = new Point(88, 134);
            DeadPersonsCount.Name = "DeadPersonsCount";
            DeadPersonsCount.Size = new Size(16, 18);
            DeadPersonsCount.TabIndex = 14;
            DeadPersonsCount.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(207, 22);
            label8.Name = "label8";
            label8.Size = new Size(46, 18);
            label8.TabIndex = 3;
            label8.Text = "Tura: ";
            // 
            // deadPersonCounByDisease
            // 
            deadPersonCounByDisease.AutoSize = true;
            deadPersonCounByDisease.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deadPersonCounByDisease.Location = new Point(156, 152);
            deadPersonCounByDisease.Name = "deadPersonCounByDisease";
            deadPersonCounByDisease.Size = new Size(16, 18);
            deadPersonCounByDisease.TabIndex = 17;
            deadPersonCounByDisease.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(30, 51);
            label4.Name = "label4";
            label4.Size = new Size(69, 18);
            label4.TabIndex = 5;
            label4.Text = "Zarażeni:";
            // 
            // labelCountDeadByDisease
            // 
            labelCountDeadByDisease.AutoSize = true;
            labelCountDeadByDisease.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCountDeadByDisease.Location = new Point(42, 152);
            labelCountDeadByDisease.Name = "labelCountDeadByDisease";
            labelCountDeadByDisease.Size = new Size(108, 18);
            labelCountDeadByDisease.TabIndex = 16;
            labelCountDeadByDisease.Text = "przez chorobę:";
            // 
            // labelCountDeadByAge
            // 
            labelCountDeadByAge.AutoSize = true;
            labelCountDeadByAge.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCountDeadByAge.Location = new Point(42, 170);
            labelCountDeadByAge.Name = "labelCountDeadByAge";
            labelCountDeadByAge.Size = new Size(83, 18);
            labelCountDeadByAge.TabIndex = 15;
            labelCountDeadByAge.Text = "przez wiek:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 134);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 2;
            label2.Text = "Zmarło:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 87);
            label6.Name = "label6";
            label6.Size = new Size(91, 18);
            label6.TabIndex = 7;
            label6.Text = "Zdrowiejący:";
            // 
            // YellowPersonsText
            // 
            YellowPersonsText.AutoSize = true;
            YellowPersonsText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            YellowPersonsText.Location = new Point(105, 51);
            YellowPersonsText.Name = "YellowPersonsText";
            YellowPersonsText.Size = new Size(16, 18);
            YellowPersonsText.TabIndex = 9;
            YellowPersonsText.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 69);
            label7.Name = "label7";
            label7.Size = new Size(57, 18);
            label7.TabIndex = 8;
            label7.Text = "Zdrowi:";
            // 
            // RedPersonsText
            // 
            RedPersonsText.AutoSize = true;
            RedPersonsText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RedPersonsText.Location = new Point(96, 105);
            RedPersonsText.Name = "RedPersonsText";
            RedPersonsText.Size = new Size(16, 18);
            RedPersonsText.TabIndex = 10;
            RedPersonsText.Text = "0";
            // 
            // GreenPersonsText
            // 
            GreenPersonsText.AutoSize = true;
            GreenPersonsText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            GreenPersonsText.Location = new Point(93, 69);
            GreenPersonsText.Name = "GreenPersonsText";
            GreenPersonsText.Size = new Size(16, 18);
            GreenPersonsText.TabIndex = 12;
            GreenPersonsText.Text = "0";
            // 
            // OrangePersonsText
            // 
            OrangePersonsText.AutoSize = true;
            OrangePersonsText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            OrangePersonsText.Location = new Point(127, 87);
            OrangePersonsText.Name = "OrangePersonsText";
            OrangePersonsText.Size = new Size(16, 18);
            OrangePersonsText.TabIndex = 11;
            OrangePersonsText.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 105);
            label5.Name = "label5";
            label5.Size = new Size(60, 18);
            label5.TabIndex = 6;
            label5.Text = "Chorzy:";
            // 
            // StopButton
            // 
            StopButton.Enabled = false;
            StopButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            StopButton.Location = new Point(684, 36);
            StopButton.Margin = new Padding(3, 2, 3, 2);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(71, 36);
            StopButton.TabIndex = 5;
            StopButton.Text = "Pause";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += PauseSimulationButton;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(580, 9);
            label11.Name = "label11";
            label11.Size = new Size(221, 25);
            label11.TabIndex = 6;
            label11.Text = "SYMULATOR CHOROBY";
            // 
            // radioButtonSick10p
            // 
            radioButtonSick10p.AutoSize = true;
            radioButtonSick10p.Location = new Point(12, 22);
            radioButtonSick10p.Name = "radioButtonSick10p";
            radioButtonSick10p.Size = new Size(55, 24);
            radioButtonSick10p.TabIndex = 7;
            radioButtonSick10p.TabStop = true;
            radioButtonSick10p.Text = "10%";
            radioButtonSick10p.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonSick50p);
            groupBox2.Controls.Add(radioButtonSick25p);
            groupBox2.Controls.Add(radioButtonSick10p);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(13, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(179, 61);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Procent zarażonych";
            // 
            // radioButtonSick50p
            // 
            radioButtonSick50p.AutoSize = true;
            radioButtonSick50p.Location = new Point(118, 22);
            radioButtonSick50p.Name = "radioButtonSick50p";
            radioButtonSick50p.Size = new Size(55, 24);
            radioButtonSick50p.TabIndex = 9;
            radioButtonSick50p.TabStop = true;
            radioButtonSick50p.Text = "50%";
            radioButtonSick50p.UseVisualStyleBackColor = true;
            // 
            // radioButtonSick25p
            // 
            radioButtonSick25p.AutoSize = true;
            radioButtonSick25p.Checked = true;
            radioButtonSick25p.Location = new Point(65, 22);
            radioButtonSick25p.Name = "radioButtonSick25p";
            radioButtonSick25p.Size = new Size(55, 24);
            radioButtonSick25p.TabIndex = 8;
            radioButtonSick25p.TabStop = true;
            radioButtonSick25p.Text = "25%";
            radioButtonSick25p.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBoxBorn);
            groupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(13, 199);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(179, 54);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Osobnik";
            // 
            // checkBoxBorn
            // 
            checkBoxBorn.AutoSize = true;
            checkBoxBorn.Checked = true;
            checkBoxBorn.CheckState = CheckState.Checked;
            checkBoxBorn.Location = new Point(12, 26);
            checkBoxBorn.Name = "checkBoxBorn";
            checkBoxBorn.Size = new Size(96, 24);
            checkBoxBorn.TabIndex = 1;
            checkBoxBorn.Text = "Narodziny";
            checkBoxBorn.UseVisualStyleBackColor = true;
            // 
            // groupBoxInitialization
            // 
            groupBoxInitialization.Controls.Add(groupBox5);
            groupBoxInitialization.Controls.Add(groupBox2);
            groupBoxInitialization.Controls.Add(groupBox3);
            groupBoxInitialization.Controls.Add(buttonCreateSimulation);
            groupBoxInitialization.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxInitialization.Location = new Point(85, 119);
            groupBoxInitialization.Name = "groupBoxInitialization";
            groupBoxInitialization.Size = new Size(351, 342);
            groupBoxInitialization.TabIndex = 10;
            groupBoxInitialization.TabStop = false;
            groupBoxInitialization.Text = "INICJALIZACJA";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(radioBtnNPops);
            groupBox5.Controls.Add(textBoxNPersons);
            groupBox5.Controls.Add(radioBtn1000Pops);
            groupBox5.Controls.Add(radioBtn100Pops);
            groupBox5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(13, 93);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(252, 100);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ilość osobników";
            // 
            // radioBtnNPops
            // 
            radioBtnNPops.AutoSize = true;
            radioBtnNPops.Location = new Point(134, 26);
            radioBtnNPops.Name = "radioBtnNPops";
            radioBtnNPops.Size = new Size(72, 24);
            radioBtnNPops.TabIndex = 12;
            radioBtnNPops.Text = "własna";
            radioBtnNPops.UseVisualStyleBackColor = true;
            radioBtnNPops.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBoxNPersons
            // 
            textBoxNPersons.BorderStyle = BorderStyle.FixedSingle;
            textBoxNPersons.Enabled = false;
            textBoxNPersons.Location = new Point(134, 56);
            textBoxNPersons.Name = "textBoxNPersons";
            textBoxNPersons.PlaceholderText = "100";
            textBoxNPersons.Size = new Size(100, 27);
            textBoxNPersons.TabIndex = 0;
            textBoxNPersons.KeyPress += textBoxNPersons_KeyPress;
            // 
            // radioBtn1000Pops
            // 
            radioBtn1000Pops.AutoSize = true;
            radioBtn1000Pops.Location = new Point(69, 26);
            radioBtn1000Pops.Name = "radioBtn1000Pops";
            radioBtn1000Pops.Size = new Size(59, 24);
            radioBtn1000Pops.TabIndex = 11;
            radioBtn1000Pops.Text = "1000";
            radioBtn1000Pops.UseVisualStyleBackColor = true;
            // 
            // radioBtn100Pops
            // 
            radioBtn100Pops.AutoSize = true;
            radioBtn100Pops.Checked = true;
            radioBtn100Pops.Location = new Point(12, 26);
            radioBtn100Pops.Name = "radioBtn100Pops";
            radioBtn100Pops.Size = new Size(51, 24);
            radioBtn100Pops.TabIndex = 10;
            radioBtn100Pops.TabStop = true;
            radioBtn100Pops.Text = "100";
            radioBtn100Pops.UseVisualStyleBackColor = true;
            // 
            // buttonCreateSimulation
            // 
            buttonCreateSimulation.Location = new Point(117, 268);
            buttonCreateSimulation.Name = "buttonCreateSimulation";
            buttonCreateSimulation.Size = new Size(111, 57);
            buttonCreateSimulation.TabIndex = 11;
            buttonCreateSimulation.Text = "Stwórz symulacje";
            buttonCreateSimulation.UseVisualStyleBackColor = true;
            buttonCreateSimulation.Click += buttonNewSimulation_Click;
            // 
            // buttonSaveSimulation
            // 
            buttonSaveSimulation.Enabled = false;
            buttonSaveSimulation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSaveSimulation.Location = new Point(680, 469);
            buttonSaveSimulation.Name = "buttonSaveSimulation";
            buttonSaveSimulation.Size = new Size(109, 57);
            buttonSaveSimulation.TabIndex = 13;
            buttonSaveSimulation.Text = "Eksportuj dane";
            buttonSaveSimulation.UseVisualStyleBackColor = true;
            buttonSaveSimulation.Click += ExportSimulationToCSV;
            // 
            // buttonRestartSimulation
            // 
            buttonRestartSimulation.Enabled = false;
            buttonRestartSimulation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRestartSimulation.Location = new Point(564, 469);
            buttonRestartSimulation.Name = "buttonRestartSimulation";
            buttonRestartSimulation.Size = new Size(109, 57);
            buttonRestartSimulation.TabIndex = 14;
            buttonRestartSimulation.Text = "Restart symulacji";
            buttonRestartSimulation.UseVisualStyleBackColor = true;
            buttonRestartSimulation.Click += RestartSimulation;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(834, 540);
            Controls.Add(buttonRestartSimulation);
            Controls.Add(buttonSaveSimulation);
            Controls.Add(groupBoxInitialization);
            Controls.Add(label11);
            Controls.Add(StopButton);
            Controls.Add(groupBox1);
            Controls.Add(StartButton);
            Controls.Add(PictureBoxGrid);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Disease Simulation";
            ((System.ComponentModel.ISupportInitialize)PictureBoxGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBoxInitialization.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
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
        private Label labelCountBornPerson;
        private Label CountsPersons;
        private Label label8;
        private Label CountTurnLabel;
        private Button StopButton;
        private Label deadPersonCountByAge;
        private Label deadPersonCounByDisease;
        private Label labelCountDeadByDisease;
        private Label labelCountDeadByAge;
        private Label label11;
        private RadioButton radioButtonSick10p;
        private GroupBox groupBox2;
        private RadioButton radioButtonSick50p;
        private RadioButton radioButtonSick25p;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private GroupBox groupBox3;
        private CheckBox checkBoxBorn;
        private GroupBox groupBoxInitialization;
        private Button buttonCreateSimulation;
        private GroupBox groupBox5;
        private TextBox textBoxNPersons;
        private RadioButton radioBtnNPops;
        private RadioButton radioBtn1000Pops;
        private RadioButton radioBtn100Pops;
        private Button buttonSaveSimulation;
        private Button buttonRestartSimulation;
    }
}