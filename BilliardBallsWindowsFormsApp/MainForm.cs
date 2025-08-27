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
                balls.Add(ball);
                ball.Start();
            }
        }
    }
}
