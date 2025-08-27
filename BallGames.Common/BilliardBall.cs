using Balls.Common;
using System;
using System.Windows.Forms;

namespace BallGames.Common
{

    public class BilliardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;
        public BilliardBall(Form form) : base(form)
        {
        }

        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide || centerX >= RightSide) vx = -vx;
            if (centerY <= TopSide || centerY >= BottomSide) vy = -vy;
        }
    }
}
