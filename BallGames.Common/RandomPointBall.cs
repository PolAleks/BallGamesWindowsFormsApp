using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomPointBall : Ball
    {
        private static Random rand = new Random();
        protected int outsideX;
        protected int outsideY;
        public RandomPointBall(Form form) : base(form)
        {
            outsideX = form.ClientSize.Width - radius;
            outsideY = form.ClientSize.Height - radius;

            centerX = rand.Next(radius, outsideX);
            centerY = rand.Next(radius, outsideY);

            vx = rand.Next(-5, 6);
            vy = rand.Next(-5, 6);
        }
    }
}
