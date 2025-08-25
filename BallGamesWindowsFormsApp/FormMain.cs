using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
    public partial class FormMain : Form
    {
        private List<MoveBall> balls;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(SystemColors.Control);

            balls = new List<MoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var ball = new MoveBall(this);
                balls.Add(ball);
                ball.Start();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            balls.ForEach(b => b.Stop());
            
            int countBall = balls.Where(b => !b.LostWindow()).Count();

            string message = GetWinMessage(countBall);

            MessageBox.Show(message, "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private string GetWinMessage(int count)
        {
            switch (count)
            {
                case 1: return $"Пойман {count} мяч";
                case 2:
                case 3:
                case 4: return $"Поймано {count} мяча";
                default: return $"Поймано {count} мячей";
            }
        }

    }
}
