using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Balls.Common;

namespace FruitNinjaWinFormApp
{
    public partial class MainForm : Form
    {
        private List<Ball> fruits;
        private Timer timer;
        private Timer slowMotionTimer;
        private int countHitBall = 0;
        private static Random random = new Random();
        private SpeedBall currentSpeed = SpeedBall.Normal;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            InitialGame();
        }

        private void InitialGame()
        {
            fruits = new List<Ball>();
            InitialShotBallsTimer();
            InitialSlowMotionTimer();

        }

        private void InitialSlowMotionTimer()
        {
            slowMotionTimer = new Timer();
            slowMotionTimer.Interval = 5000;
            slowMotionTimer.Tick += EndSlowMotionTimer_Tick;
        }

        private void EndSlowMotionTimer_Tick(object sender, EventArgs e)
        {
            currentSpeed = SpeedBall.Normal;
            SetSpeedMotionBall();
        }

        private void SetSpeedMotionBall()
        {
            fruits.ForEach(f => f.Speed(currentSpeed));
            slowMotionTimer.Enabled = !slowMotionTimer.Enabled;
        }

        private void InitialShotBallsTimer()
        {
            timer = new Timer();
            timer.Interval = 2500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int count = random.Next(5, 12);
            for (int i = 0; i < count; i++)
            {
                Ball fruit = GenerateFruit();
                fruit.Speed(currentSpeed);
                fruits.Add(fruit);
                fruit.Start();
            }
        }

        private Ball GenerateFruit()
        {
            switch (random.Next(10))
            {
                case 0: return new BombBall(this);
                case 1: return new BananaBall(this);
                default: return new FruitBallRandomSize(this);
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var fruit in fruits)
            {
                if (fruit.Contains(e.Location))
                {
                    if(fruit is BombBall)
                    {
                        GameOver();
                    }

                    if (fruit is BananaBall && currentSpeed == SpeedBall.Normal)
                    {
                        currentSpeed = SpeedBall.Slow;
                        SetSpeedMotionBall();
                    }

                    KillBall(fruit);
                    UpdateCountHitBall();

                    break;
                }
                if (!fruit.OnForm())
                {
                    KillBall(fruit);

                    break;
                }
            }
        }

        private void GameOver()
        {
            timer.Stop();
            foreach (var ball in fruits)
            {
                ball.Stop();
            }
            var resultDialog = MessageBox.Show("Увы. Вы проиграли(\nПопробуем снова?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if(resultDialog == DialogResult.Yes)
                Application.Restart();
            else
                Application.Exit();
        }

        private void UpdateCountHitBall() => hitBallValueLabel.Text = (++countHitBall).ToString();

        private void KillBall(Ball ball)
        {
            ball.Stop();
            ball.Clear();
            fruits.Remove(ball);
        }
    }
}
