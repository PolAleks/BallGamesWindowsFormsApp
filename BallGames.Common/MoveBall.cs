using System.Windows.Forms;

namespace Balls.Common
{
    public class MoveBall : RandomPointBall
    {
        public MoveBall(Form form) : base(form)
        {
            vx = GetSpeed();
            vy = GetSpeed();
        }

        private float GetSpeed() => rand.Next(2, 6) * (rand.Next(2) == 0 ? 1 : -1);
    }
}
