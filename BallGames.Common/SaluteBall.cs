using System;
using System.Windows.Forms;

namespace Balls.Common
{
    public class SaluteBall : MoveBall
    {
        private float g = 0.2f;
        public SaluteBall(Form form, float centerX, float centerY) : base(form)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            radius = rand.Next(4, 6);
            vy = -Math.Abs(vy);
        }

        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}
