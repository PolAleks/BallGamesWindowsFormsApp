using BallGames.Common;
using BallGamesWindowsFormsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMEWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<CatchMoveBall> balls;
        private int countCaughtBalls = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowCountCaughtBalls();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            balls = new List<CatchMoveBall>();
            for(int i = 0; i < 10; i++)
            {
                var ball = new CatchMoveBall(this);
                balls.Add(ball);
                ball.Start();
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = e.Location;

            for (int i = 0; i < balls.Count; i++)
            {
                var ball = balls[i];
                if (!ball.OnForm())
                {
                    balls.Remove(ball);
                    continue;
                }
                if (ball.Catch(point))
                {
                    countCaughtBalls++;
                    ShowCountCaughtBalls();
                    ball.Stop();
                }
            }
        }

        private void ShowCountCaughtBalls() => caughtBallsValueLabel.Text = countCaughtBalls.ToString();
    }
}
