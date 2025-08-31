using System;
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
            Radius = rand.Next(3, 7);

            vy = -Math.Abs(vy);
        }

        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}
