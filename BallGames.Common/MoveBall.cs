using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Balls.Common
{
    public class MoveBall : RandomPointBall
    {
        public MoveBall(Form form) : base(form)
        {
            vx = GetSpeed();
            vy = GetSpeed();
        }

        private int GetSpeed() => rand.Next(2, 6) * (rand.Next(2) == 0 ? 1 : -1);
    }
}
