using BallGames.Common;
using Balls.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CheckingDiffusionWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private Timer timer;
        private List<BilliardBall> balls;
        private int mergeForm;
        private bool testIsOver = false;
        public MainForm()
        {
            InitializeComponent();
            mergeForm = ClientSize.Width / 2;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (balls == null)
            {
                GetBalls();
            }
            else
            {
                if (!testIsOver)
                {
                    timer.Enabled = !timer.Enabled;

                    foreach (var ball in balls)
                    {
                        if (ball.IsMovable()) ball.Stop();
                        else ball.Start();
                    }
                }
                else
                {
                    var resultDialog = MessageBox.Show("Повторить?", "Шарики равномерно перемешаны", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultDialog == DialogResult.Yes)
                    {
                        ClearForm();
                        GetBalls();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void ClearForm()
        {
            CreateGraphics().Clear(SystemColors.Control);

            leftBlueLabel.Text = "0";
            rightBlueLabel.Text = "0";
            topBlueLabel.Text = "0";
            bottomBlueLabel.Text = "0";

            leftRedLabel.Text = "0";
            rightRedLabel.Text = "0";
            topRedLabel.Text = "0";
            bottomRedLabel.Text = "0";

            testIsOver = false;
        }

        private void GetBalls()
        {
            balls = new List<BilliardBall>();

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
            timer = new Timer();
            timer.Interval = 25;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var countLeftSideRedBall = balls.Where(b => b.Color == Color.Red).Count(b => b.X < mergeForm);
            var countLeftSideBlueBall = balls.Where(b => b.Color == Color.Blue).Count(b => b.X > mergeForm);

            var countRightSideRedBall = balls.Where(b => b.Color == Color.Red).Count(b => b.X > mergeForm);
            var countRightSideBlueBall = balls.Where(b => b.Color == Color.Blue).Count(b => b.X < mergeForm);

            if (countLeftSideRedBall == countRightSideRedBall && countLeftSideBlueBall == countRightSideBlueBall)
            {
                timer.Stop();
                foreach (var ball in balls)
                {
                    ball.Stop();
                }
                testIsOver = true;
            }
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
