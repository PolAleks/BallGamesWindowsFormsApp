using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Balls.Common;

namespace FruitNinjaWinFormApp
{
    public partial class MainForm : Form
    {
        private List<Ball> fruits;
        private Timer timer;
        private int countHitBall = 0;
        private static Random random = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {            
            InitialGame();
        }

        private void InitialGame()
        {
            fruits = new List<Ball>();

            timer = new Timer();
            timer.Interval = 2500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            int count = random.Next(5, 12);
            for (int i = 0; i < count; i++)
            {
                Ball fruit = GenerateFruit();
                fruits.Add(fruit);
                fruit.Start();
            }
        }

        private Ball GenerateFruit()
        {
            switch (random.Next(10))
            {
                case 0: return new BombBall(this);
                default: return new FruitBallRandomSize(this);
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var fruit in fruits)
            {
                if (fruit.Contains(e.Location))
                {
                    if(fruit is BombBall)
                    {
                        GameOver();
                    }
                    KillBall(fruit);
                    UpdateCountHitBall();

                    break;
                }
                if (!fruit.OnForm())
                {
                    KillBall(fruit);

                    break;
                }
            }
        }

        private void GameOver()
        {
            timer.Stop();
            foreach (var ball in fruits)
            {
                ball.Stop();
            }
            var resultDialog = MessageBox.Show("Увы. Вы проиграли(\nПопробуем снова?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if(resultDialog == DialogResult.Yes)
                Application.Restart();
            else
                Application.Exit();
        }

        private void UpdateCountHitBall() => hitBallValueLabel.Text = (++countHitBall).ToString();

        private void KillBall(Ball ball)
        {
            ball.Stop();
            ball.Clear();
            fruits.Remove(ball);
        }
    }
}
