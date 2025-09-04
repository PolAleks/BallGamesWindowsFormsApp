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
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            var ball = new ShotBallRandomSize(this);
            balls.Add(ball);
            ball.Start();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var ball in balls)
            {
                if (ball.Contains(e.Location))
                {
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

        private void UpdateCountHitBall() => hitBallValueLabel.Text = (++countHitBall).ToString();

        private void KillBall(Ball ball)
        {
            ball.Stop();
            ball.Clear();
            balls.Remove(ball);
        }
    }
}
