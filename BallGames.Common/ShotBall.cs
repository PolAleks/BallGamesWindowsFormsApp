using Balls.Common;
using System;
using System.Windows.Forms;

namespace BallGames.Common
{
    public class ShotBall : MoveBall
    {
        private float g = 0.1f;
        public event EventHandler<BoomEventArgs> OnBaDaBoom;
        public ShotBall(Form form, float x) : base(form)
        {
            centerX = x;
            centerY = BottomSide;
            radius = 5;

            vx = rand.Next(0, 3) * (rand.Next(2) == 0 ? 1 : -1);
            vy = -Math.Abs(rand.Next(5,8));
        }

        protected override void Go()
        {
            base.Go();
            vy += g;
            if (vy >= 0)
            {
                Stop();
                Clear();
                OnBaDaBoom?.Invoke(this, new BoomEventArgs(rand.Next(7, 16), centerX, centerY));
            }
        }
    }
}