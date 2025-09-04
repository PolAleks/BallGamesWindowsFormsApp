using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class ShotBallRandomSize : MoveBall
    {
        private static readonly Color[] basicColors = new Color[]
        {
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.Yellow,
            Color.Magenta,
            Color.Cyan,
            Color.Orange,
            Color.Purple,
            Color.Brown,
            Color.Pink,
            Color.White,
            Color.Black,
            Color.Gray
        };

        private float g = 0.2f;
        public ShotBallRandomSize(Form form) : base(form)
        {
            CenterX = RightSide / 2;
            CenterY = BottomSide;
        }

        protected override void InitialSpeed()
        {
            vx = rand.Next(0, 5) * (rand.Next(2) == 0 ? 1 : -1);
            vy = -Math.Abs(rand.Next(10, 12));
        }
        protected override void InitialRadius()
        {
            Radius = rand.Next(15, 30);
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
        }

        protected override void InitialColor()
        {
            int index = rand.Next(basicColors.Length);
            color = basicColors[index];
        }
    }
}
