using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class BilliardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;
        public Color Color => color;
        public BilliardBall(Form form, Color color, Side side) : base(form)
        {
            this.color = color;
            switch (side)
            {
                case Side.Left: 
                    CenterX = rand.Next(LeftSide, form.ClientSize.Width / 2 - Radius);
                    break;
                case Side.Right:
                    CenterX = rand.Next(form.ClientSize.Width / 2 - Radius, RightSide);
                    break;
                case Side.Top:
                    CenterY = rand.Next(TopSide, form.ClientSize.Height / 2 - Radius);
                    break;
                case Side.Bottom:
                    CenterY = rand.Next(form.ClientSize.Width / 2  + Radius, BottomSide);
                    break;
            }
        }

        public BilliardBall(Form form) : base(form) { }

        protected override void Go()
        {
            base.Go();
            if (CenterX < LeftSide)
            {
                CenterX = LeftSide;
                vx = -vx;
                OnHited?.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (CenterX > RightSide)
            {
                CenterX = RightSide;
                vx = -vx;
                OnHited?.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (CenterY < TopSide)
            {
                CenterY = TopSide;
                vy = -vy;
                OnHited?.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (CenterY > BottomSide)
            {
                CenterY = BottomSide;
                vy = -vy;
                OnHited?.Invoke(this, new HitEventArgs(Side.Bottom));
            }
        }
    }
}
