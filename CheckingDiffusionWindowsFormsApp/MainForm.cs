using BallGames.Common;
using Balls.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CheckingDiffusionWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private Timer timer;
        private List<Ball> balls;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (balls == null)
            {
                balls = new List<Ball>();

                for (int i = 0; i < 10; i++)
                {
                    var ball = new BilliardBall(this, Color.Blue, Side.Left);
                    balls.Add(ball);
                    ball.OnHited += Ball_OnHited;
                    ball.Start();
                }

                for (int i = 0; i < 10; i++)
                {
                    var ball = new BilliardBall(this, Color.Red, Side.Right);
                    balls.Add(ball);
                    ball.OnHited += Ball_OnHited;
                    ball.Start();
                }

                timer.Interval = 20;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            else
            {
                timer.Enabled = !timer.Enabled;

                foreach (var ball in balls)
                {
                    if (ball.IsMovable()) ball.Stop();
                    else ball.Start();
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Ball_OnHited(object sender, HitEventArgs e)
        {
            if (sender is BilliardBall ball)
            {
                Color color = ball.Color;

                switch (e.Side)
                {
                    case Side.Left when color == Color.Red:
                        leftRedLabel.Text = (Convert.ToInt32(leftRedLabel.Text) + 1).ToString();
                        break;
                    case Side.Right when color == Color.Red:
                        rightRedLabel.Text = (Convert.ToInt32(rightRedLabel.Text) + 1).ToString();
                        break;
                    case Side.Top when color == Color.Red:
                        topRedLabel.Text = (Convert.ToInt32(topRedLabel.Text) + 1).ToString();
                        break;
                    case Side.Bottom when color == Color.Red:
                        bottomRedLabel.Text = (Convert.ToInt32(bottomRedLabel.Text) + 1).ToString();
                        break;
                    case Side.Left when color == Color.Blue:
                        leftBlueLabel.Text = (Convert.ToInt32(leftBlueLabel.Text) + 1).ToString();
                        break;
                    case Side.Right when color == Color.Blue:
                        rightBlueLabel.Text = (Convert.ToInt32(rightBlueLabel.Text) + 1).ToString();
                        break;
                    case Side.Top when color == Color.Blue:
                        topBlueLabel.Text = (Convert.ToInt32(topBlueLabel.Text) + 1).ToString();
                        break;
                    case Side.Bottom when color == Color.Blue:
                        bottomBlueLabel.Text = (Convert.ToInt32(bottomBlueLabel.Text) + 1).ToString();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
