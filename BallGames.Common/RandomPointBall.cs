using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
    public class RandomPointBall : Ball
    {
        private Size _size;
        private static Random rand = new Random();
        protected int outsideX;
        protected int outsideY;
        public RandomPointBall(Form form) : base(form)
        {
            outsideX = form.ClientSize.Width - size;
            outsideY = form.ClientSize.Height - size;

            x = rand.Next(size, outsideX);
            y = rand.Next(size, outsideY);

            vx = rand.Next(-5, 6);
            vy = rand.Next(-5, 6);
        }
    }
}
