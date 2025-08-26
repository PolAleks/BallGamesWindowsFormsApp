using System;
using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
    public class MoveBall : RandomPointBall
    {
        private Timer _timer;
        public MoveBall(Form form) : base(form)
        {
            _timer = new Timer();
            _timer.Interval = 20;
            _timer.Tick += _timer_Tick;
        }

        public bool OnForm() => x >= 0 && x <= outsideX && y >= 0 && y <= outsideY;

        private void _timer_Tick(object sender, EventArgs e) => Move();

        public void Start() => _timer.Start();

        public void Stop() => _timer.Stop();
    }
}
