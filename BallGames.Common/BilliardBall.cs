using Balls.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallGames.Common
{
    public class BilliardBall : MoveBall
    {
        
        public event EventHandler<HitEventArgs> OnHited;
        public BilliardBall(Form form, Color color, Side side) : base(form)
        {
            this.color = color;
            switch (side)
            {
                case Side.Left: 
                    centerX = rand.Next(LeftSide, form.ClientSize.Width / 2 - radius);
                    break;
                case Side.Right:
                    centerX = rand.Next(form.ClientSize.Width / 2 - radius, RightSide);
                    break;
                case Side.Top:
                    centerY = rand.Next(TopSide, form.ClientSize.Height / 2 - radius);
                    break;
                case Side.Bottom:
                    centerY = rand.Next(form.ClientSize.Width / 2  + radius, BottomSide);
                    break;
            }
        }

        public BilliardBall(Form form) : base(form)
        {
        }

        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide)
            {
                vx = -vx;
                OnHited?.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide)
            {
                vx = -vx;
                OnHited?.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= TopSide)
            {
                vy = -vy;
                OnHited?.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= BottomSide)
            {
                vy = -vy;
                OnHited?.Invoke(this, new HitEventArgs(Side.Bottom));
            }
        }
    }
}
