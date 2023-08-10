using System.Text.Json;

namespace DiseaseSimulation
{
    public partial class Form1 : Form
    {
        private Simulation simulation;
        public Form1()
        {
            InitializeComponent();
        }
        private void SimulationTimerTurn(object sender, EventArgs e)
        {
            simulation.TurnSession();
            UpdateUITextLabel();
            StopSimulation();
            PictureBoxGrid.Invalidate();
        }
        private void UpdatePictureBox(object sender, PaintEventArgs e)
        {
            Graphics pic = e.Graphics;

            for (int i = 0; i < simulation.N; i++)
            {
                int[] XY = simulation.Persons[i].GetCurrentPosition();
                string cond = simulation.Persons[i].GetDiseaseCondition();
                SolidBrush color = CheckColor(cond);
                Rectangle rect = new Rectangle(XY[0] * 5, XY[1] * 5, 8, 8);
                pic.FillEllipse(color, rect);
            }
        }
        private SolidBrush CheckColor(string condition)
        {
            if (condition == "C")    // Kolor czerwony - chory (C)
            {
                SolidBrush red = new SolidBrush(Color.Red);
                return red;
            }
            else if (condition == "Z")  // Kolor zolty - zarazony (Z)
            {
                SolidBrush yellow = new SolidBrush(Color.Yellow);
                return yellow;
            }
            else if (condition == "ZD")     // Kolor pomaranczony - zdrowiejacy (ZD)
            {
                SolidBrush orange = new SolidBrush(Color.Orange);
                return orange;
            }
            else    // Kolor zielony - zdrowy (ZZ)
            {
                SolidBrush green = new SolidBrush(Color.Green);
                return green;
            }
        }
        private void UpdateUITextLabel()
        {
            CountTurnLabel.Text = simulation.turnCount.ToString();
            GreenPersonsText.Text = simulation.greenPersonsCount.ToString();
            YellowPersonsText.Text = simulation.yellowPersonsCount.ToString();
            OrangePersonsText.Text = simulation.orangePersonsCount.ToString();
            RedPersonsText.Text = simulation.redPersonsCount.ToString();
            DeadPersonsCount.Text = simulation.deadPersonsCount.ToString();
            deadPersonCountByAge.Text = simulation.deadCountByAge.ToString();
            deadPersonCounByDisease.Text = simulation.deadCountByDisease.ToString();
            BornPersonsCount.Text = simulation.birthPersonsCount.ToString();
            CountsPersons.Text = simulation.N.ToString();
        }

        private void buttonNewSimulation_Click(object sender, EventArgs e)
        {
            groupBoxInitialization.Visible = false;
            initializationSimulation();
        }

        private void StopSimulation()
        {
            if (simulation.greenPersonsCount == simulation.N)
            {
                SimulationTimerClock.Stop();
                StopButton.Enabled = false;
                StartButton.Enabled = false;
            }
        }
        private void StartSimulationButton(object sender, EventArgs e)
        {
            SimulationTimerClock.Start();
            StopButton.Enabled = true;
            StartButton.Enabled = false;
        }
        private void PauseSimulationButton(object sender, EventArgs e)
        {
            SimulationTimerClock.Stop();
            StopButton.Enabled = false;
            StartButton.Enabled = true;
        }

        private void initializationSimulation()
        {
            double red = 0;
            int N = 100;
            bool ischeckced = false;
            if (radioButtonSick10p.Checked == true)
            {
                red = 0.1;
            }
            else if (radioButtonSick25p.Checked == true)
            {
                red = 0.25;
            }
            else
            {
                red = 0.5;
            }

            if(radioBtn100Pops.Checked == true)
            {
                N = 100;
            }
            else if (radioBtn1000Pops.Checked == true)
            {
                N = 1000;
            }
            else if (radioBtnNPops.Checked == true)
            {
                if (textBoxNPersons.Text != "")
                {
                    N = int.Parse(textBoxNPersons.Text);
                }
            }

            if (checkBoxBorn.Checked == true)
            {
                ischeckced = true;
            }

            simulation = new Simulation(N, red, ischeckced, 100, 100);
            PictureBoxGrid.Visible = true;
            StopButton.Enabled = true;
            StartButton.Enabled = false;
            buttonSaveSimulation.Enabled = true;
            groupBoxInitialization.Enabled = false;
            StartButton.Enabled = true;
        }

        private int[] getSizePictureBox()
        {
            int x = PictureBoxGrid.Size.Width;
            int y = PictureBoxGrid.Size.Height;
            return new int[] { x, y };
        }

        private void SaveSimulationToJSON(object sender, EventArgs e)
        {
            string jsonString = JsonSerializer.Serialize(simulation);
            File.WriteAllText("data.json", jsonString);
        }
        private void LoadSimulationFromJSON(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string jsonString = File.ReadAllText(filePath);
                simulation = JsonSerializer.Deserialize<Simulation>(jsonString);
                groupBoxInitialization.Visible = false;
                PictureBoxGrid.Visible = true;
                StopButton.Enabled = true;
                StartButton.Enabled = false;
                buttonSaveSimulation.Enabled = true;
                groupBoxInitialization.Enabled = false;
                StartButton.Enabled = true;
            }
        }

        private void textBoxNPersons_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnNPops.Checked)
                textBoxNPersons.Enabled = true;
            else
                textBoxNPersons.Enabled = false;
        }

        private void pictureBoxGrid_MouseMove(object sender, MouseEventArgs e)
        {
            Point localPoint = PictureBoxGrid.PointToClient(MousePosition);
            int x = localPoint.X;
            int y = localPoint.Y;
            string msg = simulation.CheckMouseCordinateWithPersons(x, y);
            if (msg != "")
            {
                MessageBox.Show(msg, "Osobnik");
            }
        }
    }
}