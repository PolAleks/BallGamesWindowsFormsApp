using BallGames.Common;
using Balls.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BilliardBallsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<Ball> balls;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            balls = new List<Ball>(10);

            for (int i = 0; i < balls.Capacity; i++)
            {
                var ball = new BilliardBall(this);
                ball.Start();
                ball.OnHited += Ball_OnHited;

                balls.Add(ball);
            }
        }

        private void Ball_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left: 
                    leftLabel.Text = (Convert.ToInt32(leftLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightLabel.Text = (Convert.ToInt32(rightLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topLabel.Text = (Convert.ToInt32(topLabel.Text) + 1).ToString();
                    break;
                case Side.Bottom:
                    bottomLabel.Text = (Convert.ToInt32(bottomLabel.Text) + 1).ToString();
                    break;
            }
        }
    }
}
