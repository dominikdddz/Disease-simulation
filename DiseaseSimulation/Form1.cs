namespace DiseaseSimulation
{
    public partial class Form1 : Form
    {
        private Simulation simulation = new Simulation();
        public Form1()
        {
            InitializeComponent();
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

        private void StopSimulation()
        {
            if (simulation.deadPersonsCount == simulation.N || simulation.greenPersonsCount == simulation.N)
            {
                SimulationTimerClock.Stop();
                StopButton.Enabled = false;
                StartButton.Enabled = false;
            }
        }

        private void ExportSimulationDataToCsvFile()  { }
        private void ImporCsvFileDataToSimulation() { }

        private void SimulationTimerTurn(object sender, EventArgs e)
        {
            simulation.TurnSession();
            UpdateUITextLabel();
            StopSimulation();
            PictureBoxGrid.Invalidate();
        }

        private void StartSimulationButton(object sender, EventArgs e)
        {
            PictureBoxGrid.Visible = true;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CountsPersons_Click(object sender, EventArgs e)
        {

        }

        private void CountPersonsText_Click(object sender, EventArgs e)
        {

        }


    }
}