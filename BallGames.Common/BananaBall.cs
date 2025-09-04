using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class BananaBall : FruitBallRandomSize
    {
        public BananaBall(Form form) : base(form)
        {
        }
        protected override void InitialColor()
        {
            color = Color.Yellow;
        }
    }
}
