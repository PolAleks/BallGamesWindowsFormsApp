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
        private Timer timer;
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
            CreateGraphics().Clear(BackColor);
            TurnButtonCreate();

            countCaughtBalls = 0;
            ShowCountCaughtBalls();

            balls = new List<CatchMoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var ball = new CatchMoveBall(this);
                balls.Add(ball);
                ball.Start();
            }

            InitialTimer();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = e.Location;

            if (balls != null)
            {
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
                        if (ball.IsMovable())
                        {
                            countCaughtBalls++;
                            ShowCountCaughtBalls();
                            ball.Stop();
                        }
                    }
                }
            }
        }

        private void ShowCountCaughtBalls() => caughtBallsValueLabel.Text = countCaughtBalls.ToString();

        private void TurnButtonCreate() => createButton.Enabled = !createButton.Enabled;

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

        private void InitialTimer()
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!balls.Where(b => b.OnForm()).Any(b => b.IsMovable()))
            {
                timer.Stop();

                string message = GetWinMessage(countCaughtBalls);
                MessageBox.Show(message, "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TurnButtonCreate();
            }
        }
    }
}
