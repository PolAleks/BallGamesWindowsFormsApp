using Balls.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGames.Common
{
    public class ShotBall : MoveBall
    {
        private float g = 0.1f;
        public event EventHandler<BoomEventArgs> OnBaDaBoom;
        public ShotBall(Form form) : base(form)
        {
            centerY = BottomSide;
            radius = rand.Next(2, 5);
            vy = -Math.Abs(vy);
        }

        protected override void Go()
        {
            base.Go();
            vy += g;
            if (vy <= 0)
            {
                Stop();
                Clear();
                OnBaDaBoom?.Invoke(this, new BoomEventArgs(rand.Next(7, 16)));
            }
        }
    }

    public class BoomEventArgs : EventArgs
    {
        public int Count { get; }
        public BoomEventArgs(int count)
        {
            Count = count;
        }
    }
}