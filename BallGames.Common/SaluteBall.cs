using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class SaluteBall : MoveBall
    {
        private float g = 0.2f;
        public SaluteBall(Form form, float centerX, float centerY) : base(form)
        {
            CenterX = centerX;
            CenterY = centerY;
        }

        protected override void Go()
        {
            base.Go();
            vy += g;
        }
        protected override void InitialRadius()
        {
            Radius = rand.Next(5, 17);
        }

        protected override void InitialSpeed()
        {
            base.InitialSpeed();
            vy = -Math.Abs(vy);
        }
    }
}
