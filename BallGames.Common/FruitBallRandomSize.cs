using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class FruitBallRandomSize : MoveBall
    {
        private static readonly Color[] basicColors = new Color[]
        {
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.Magenta,
            Color.Cyan,
            Color.Orange,
            Color.Purple,
            Color.Brown,
            Color.Pink,
            Color.White,
            Color.Gray
        };

        private float g = 0.2f;
        public FruitBallRandomSize(Form form) : base(form)
        {
            CenterY = BottomSide;
        }

        protected override void InitialSpeed()
        {
            vx = rand.Next(0, 5) * (rand.Next(2) == 0 ? 1 : -1);
            vy = -Math.Abs(rand.Next(7, 15));
        }
        protected override void InitialRadius()
        {
            Radius = rand.Next(20, 30);
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
