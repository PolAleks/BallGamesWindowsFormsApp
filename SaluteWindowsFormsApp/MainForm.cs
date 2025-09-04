using Balls.Common;
using System;
using System.Windows.Forms;

namespace SaluteWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private static Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            float centerX = e.X;
            var shotBall = new ShotBall(this, centerX);
            shotBall.OnBaDaBoom += ShotBall_OnBaDaBoom;
            shotBall.Start();
        }

        private void ShotBall_OnBaDaBoom(object sender, BoomEventArgs e)
        {
            for (int i = 0; i < e.Count; i++)
            {
                var ball = new SaluteBall(this, e.X, e.Y);
                ball.Start();
            }
        }
    }
}
