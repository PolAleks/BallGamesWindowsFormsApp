using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class Ball
    {
        private Timer _timer;
        protected Form form;
        protected Graphics graphics;
        protected Color color = Color.LightBlue;

        protected float centerX = 150f;
        protected float centerY = 150f;
        protected int radius = 25;

        protected float vx = 10f;
        protected float vy = 10f;

        #region Границы поля
        public int LeftSide => radius;
        public int RightSide => form.ClientSize.Width - radius;
        public int TopSide => radius;
        public int BottomSide => form.ClientSize.Height - radius;
        #endregion
        public Ball(Form form)
        {
            this.form = form;
            graphics = form.CreateGraphics();

            _timer = new Timer();
            _timer.Interval = 20;
            _timer.Tick += _timer_Tick;
        }
        private void _timer_Tick(object sender, EventArgs e) => Move();
        public void Start() => _timer.Start();
        public void Stop() => _timer.Stop();
        public bool IsMovable() => _timer.Enabled;
        public bool OnForm() => centerX >= LeftSide && centerX <= RightSide && centerY >= TopSide && centerY <= BottomSide;

        public void Move()
        {
            Clear();
            Go();
            Show();
        }
        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        public void Show() => Draw(color);
        protected void Clear() => Draw(SystemColors.Control);
        private void Draw(Color color)
        {
            var brush = new SolidBrush(color);
            var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
