using Balls.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGames.Common
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
