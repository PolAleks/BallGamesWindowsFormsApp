using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomPointBall : Ball
    {
        private static Random rand = new Random();
        
        public RandomPointBall(Form form) : base(form)
        {
            centerX = rand.Next(LeftSide, RightSide);
            centerY = rand.Next(TopSide, BottomSide);

            vx = rand.Next(-5, 6);
            vy = rand.Next(-5, 6);
        }
    }
}
