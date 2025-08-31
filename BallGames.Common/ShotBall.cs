using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class ShotBall : MoveBall
    {
        private float g = 0.1f;
        public event EventHandler<BoomEventArgs> OnBaDaBoom;
        public ShotBall(Form form, float x) : base(form)
        {
            CenterX = x;
            CenterY = BottomSide;            
        }

        protected override void InitialRadius() => Radius = 7;
        protected override void InitialSpeed()
        {
            vx = rand.Next(0, 3) * (rand.Next(2) == 0 ? 1 : -1);
            vy = -Math.Abs(rand.Next(5, 8));
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
            if (vy >= 0)
            {
                Stop();
                OnBaDaBoom?.Invoke(this, new BoomEventArgs(rand.Next(7, 16), CenterX, CenterY));
                Clear();
            }
        }
    }
}