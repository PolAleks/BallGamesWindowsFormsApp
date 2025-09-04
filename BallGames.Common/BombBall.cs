using Balls.Common;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class BombBall : FruitBallRandomSize
    {
        public BombBall(Form form) : base(form)
        {
        }
        protected override void InitialColor()
        {
            color = Color.Black;
        }
    }
}
