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
            int countSaluteBall = random.Next(5, 11);
            for (int i = 0; i < countSaluteBall; i++)
            {
                var saluteBall = new SaluteBall(this, e.X, e.Y);
                saluteBall.Start();
            }
        }
    }
}
