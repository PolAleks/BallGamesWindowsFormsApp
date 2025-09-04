using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Balls.Common;

namespace FruitNinjaWinFormApp
{
    public partial class MainForm : Form
    {
        private List<Ball> balls;
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
            balls = new List<Ball>();

            timer = new Timer();
            timer.Interval = 2500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            int count = random.Next(5, 16);
            for (int i = 0; i < count; i++)
            {
                var ball = new ShotBallRandomSize(this);
                balls.Add(ball);
                ball.Start();
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var ball in balls)
            {
                if (ball.Contains(e.Location))
                {
                    if(ball.color == Color.Black)
                    {
                        GameOver();
                    }
                    KillBall(ball);
                    UpdateCountHitBall();

                    break;
                }
                if (!ball.OnForm())
                {
                    KillBall(ball);

                    break;
                }
            }
        }

        private void GameOver()
        {
            timer.Stop();
            foreach (var ball in balls)
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
            balls.Remove(ball);
        }
    }
}
