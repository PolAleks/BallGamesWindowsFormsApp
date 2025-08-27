using BallGames.Common;
using Balls.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckingDiffusionWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<Ball> balls;
        private int merge;
        public MainForm()
        {
            InitializeComponent();
            merge = ClientSize.Width;
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
                    ball.Start();
                }

                for (int i = 0; i < 10; i++)
                {
                    var ball = new BilliardBall(this, Color.Red, Side.Right);
                    balls.Add(ball);
                    ball.Start();
                }
            }
            else
            {
                foreach (var ball in balls)
                {
                    if (ball.IsMovable()) ball.Stop();
                    else ball.Start();
                }
            }
        }
    }
}
