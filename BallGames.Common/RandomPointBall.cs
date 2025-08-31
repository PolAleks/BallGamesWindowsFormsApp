using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomPointBall : Ball
    {
        protected static Random rand = new Random();
        public RandomPointBall(Form form) : base(form) { }
        protected override Point GetPoint()
        {
            int x = rand.Next(LeftSide, RightSide);
            int y = rand.Next(TopSide, BottomSide); 
            return new Point(x, y);
        }
    }
}
