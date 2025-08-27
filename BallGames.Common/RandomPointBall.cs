using System;
using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomPointBall : Ball
    {
        protected static Random rand = new Random();
        public RandomPointBall(Form form) : base(form)
        {
            centerX = rand.Next(LeftSide, RightSide);
            centerY = rand.Next(TopSide, BottomSide);
        }
    }
}
