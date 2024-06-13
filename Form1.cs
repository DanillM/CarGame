using System.Diagnostics;
using System.Numerics;
using static System.Formats.Asn1.AsnWriter;

namespace CarGame
{
    public partial class Form1 : Form
    {
        private int BestScore1 = 0;
        private double score = 0;
        private int roadSpeed;
        private bool goleft;
        private bool goright;
        private bool speedup;
        private bool speeddown;
        private int carImage;
        private int trafficSpeed;
        Random random = new Random();
        Random carPosition = new Random();
        public Form1()
        {
            InitializeComponent();


            /*
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(0, 10));
            }
            */

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            score = score + 0.1;
            int scoreInt = (int)score;
            Score.Text = "Score: " + scoreInt;


            if (BestScore1 < scoreInt)
            {
                BestScore1 = scoreInt;
            }


            BestScore.Text = "Best Score: " + BestScore1;


            roadTruck1.Top = roadTruck1.Top + roadSpeed;
            roadTruck2.Top = roadTruck2.Top + roadSpeed;
            Debug.WriteLine(roadTruck1.Top);
            //Debug.WriteLine(roadTruck2.Top);
            Debug.WriteLine(roadTruck2.Bottom);
            if (roadTruck1.Top > 555)
            {
                roadTruck1.Top = -554;
            }
            if (roadTruck2.Top > 555)
            {
                roadTruck2.Top = -554;
            }
            if (roadTruck1.Top < -555)
            {
                roadTruck1.Top = 554;
            }
            if (roadTruck2.Top < -555)
            {
                roadTruck2.Top = 554;
            }
            //Debug.WriteLine("Left", (roadTruck1.Left).ToString());
            //Debug.WriteLine("Right", (roadTruck1.Right).ToString());
            if (goleft == true && player.Left > roadTruck2.Left)
            {
                player.Left = player.Left - 10;
            }
            if (goright == true && player.Right < roadTruck2.Right)
            {
                player.Left = player.Left + 10;
            }
            if (speedup == true)
            {
                trafficSpeed++;
                roadSpeed = roadSpeed + 1;
            }
            if (speeddown == true && trafficSpeed > 20)
            {
                trafficSpeed--;
                roadSpeed = roadSpeed - 1;
            }
            if (roadSpeed < 15)
            {
                roadSpeed = 15;
            }
            AI1.Top = AI1.Top + trafficSpeed;
            AI2.Top = AI2.Top + trafficSpeed;

            if (AI1.Top > 700)
            {
                changeAIcars(AI1);
            }
            if (AI2.Top > 700)
            {
                changeAIcars(AI2);
            }

            if (player.Bounds.IntersectsWith(AI1.Bounds))
            {
                gameTimer.Stop();
                Start.Text = "Restart";
                Start.Enabled = true;

            }
            if (player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameTimer.Stop();
                Start.Text = "Restart";
                Start.Enabled = true;

            }
        }

        private void Start_Click(object sender, EventArgs e)
        {

            score = 0;
            player.Location = new Point(277, 539);
            changeAIcars(AI1);
            changeAIcars(AI2);
            AI1.Visible = true;
            AI2.Visible = true;
            AI1.Location = new Point(78, 357);
            AI2.Location = new Point(441, 272);
            roadSpeed = 15;
            gameTimer.Start();
            Start.Enabled = false;
            trafficSpeed = 20;


        }


        private void player_Click(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //Debug.WriteLine(e.KeyCode);
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Up)
            {
               
                speedup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
               
                speeddown = true;
            }


        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                speedup = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                speeddown = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void changeAIcars(PictureBox tempCar)
        {
            carImage = random.Next(1, 10);
            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
            }
            tempCar.Top = carPosition.Next(100, 400) * -1;

            if ((string)tempCar.Tag == "AI1")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "AI2")
            {
                tempCar.Left = carPosition.Next(220, 420);
            }



        }

        private void roadTruck2_Click(object sender, EventArgs e)
        {

        }
    }
}