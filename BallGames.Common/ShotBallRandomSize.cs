using System;
using System.Windows.Forms;

namespace Balls.Common
{
    public class ShotBallRandomSize : MoveBall
    {
        private float g = 0.2f;
        public ShotBallRandomSize(Form form) : base(form)
        {
            CenterX = RightSide / 2;
            CenterY = BottomSide;            
        }

        protected override void InitialSpeed()
        {
            vx = rand.Next(0, 5) * (rand.Next(2) == 0 ? 1 : -1);
            vy = -Math.Abs(rand.Next(10, 12));
        }
        protected override void InitialRadius()
        {
            Radius = rand.Next(15, 30);
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}
