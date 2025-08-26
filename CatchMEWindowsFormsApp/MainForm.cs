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
        public MainForm()
        {
            InitializeComponent();
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
    }
}
