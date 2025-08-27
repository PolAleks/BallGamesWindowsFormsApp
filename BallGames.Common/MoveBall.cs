using System;
using System.Windows.Forms;

namespace Balls.Common
{
    public class MoveBall : RandomPointBall
    {
        private Timer _timer;
        public MoveBall(Form form) : base(form)
        {
            _timer = new Timer();
            _timer.Interval = 50;
            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object sender, EventArgs e) => Move();

        public void Start() => _timer.Start();

        public void Stop() => _timer.Stop();

        public bool IsMovable() => _timer.Enabled;
    }
}
