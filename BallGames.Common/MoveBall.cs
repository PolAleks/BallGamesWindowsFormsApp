using System.Windows.Forms;

namespace Balls.Common
{
    public class MoveBall : RandomPointBall
    {
        public MoveBall(Form form) : base(form) { }

        private float GetSpeed() => rand.Next(2, 6) * (rand.Next(2) == 0 ? 1 : -1);
        protected override void InitialSpeed()
        {
            vx = GetSpeed();
            vy = GetSpeed();
        }
        protected override void InitialRadius()
        {
            Radius = 15;
        }
    }
}
