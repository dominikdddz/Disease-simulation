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
                int[] XY = simulation.Persons[i].getPosition();
                string cond = simulation.Persons[i].getCondition();
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
            CountTurnLabel.Text = simulation.CountTurns.ToString();
            GreenPersonsText.Text = simulation.GreenPersons.ToString();
            YellowPersonsText.Text = simulation.YellowPersons.ToString();
            OrangePersonsText.Text = simulation.OrangePersons.ToString();
            RedPersonsText.Text = simulation.RedPersons.ToString();
            CountsPersons.Text = simulation.N.ToString();
        }

        private void SimulationTimer(object sender, EventArgs e)
        {
            UpdateUITextLabel();
            simulation.TurnSession();
            PictureBoxGrid.Invalidate();
        }

        private void StartSimulation(object sender, EventArgs e)
        {
            PictureBoxGrid.Visible = true;
            SimulationTimerClock.Start();
            StopButton.Enabled = true;
            StartButton.Enabled = false;
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = true;
            StopButton.Enabled = false;
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