namespace DiseaseSimulation
{
    public partial class Form1 : Form
    {
        private Simulation simulation = new Simulation();
        public Form1()
        {
            InitializeComponent();
            DrawPerson();
        }
        
        private void DrawPerson()
        {

        }

        private void UpdatePictureBox(object sender, PaintEventArgs e)
        {
            Graphics pic = e.Graphics;
            
            for (int i = 0; i < 10; i++)
            {
                int[] cor = simulation.Persons[i].getPosition();
                string cond = simulation.Persons[i].getCondition();
                SolidBrush color = CheckColor(cond);
                Rectangle rect = new Rectangle(cor[0]*5, cor[1]*5, 16, 16);
                pic.FillEllipse(color, rect);
            }
        }
        private SolidBrush CheckColor(string condition)
        {
            if (condition == "C")
            {
                SolidBrush red = new SolidBrush(Color.Red);
                return red;
            }
            else if (condition == "Z")
            {
                SolidBrush yellow = new SolidBrush(Color.Yellow);
                return yellow;
            }
            else if (condition == "ZD")
            {
                SolidBrush orange = new SolidBrush(Color.Orange);
                return orange;
            }
            else // "ZZ"
            {
                SolidBrush green = new SolidBrush(Color.Green);
                return green;
            }
        }
    }
}