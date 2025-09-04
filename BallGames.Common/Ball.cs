using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class Ball
    {
        private Timer timer;
        protected Form form;
        protected RectangleF bounds; //границы шара
        protected float vx;
        protected float vy;

        #region Параметры шара
        public Color color;
        public float CenterX 
        {
            get
            {
                return bounds.X + Radius;
            }
            set
            {
                bounds.X = value - Radius;
            }
        }
        protected float CenterY
        {
            get
            {
                return bounds.Y + Radius;
            }
            set
            {
                bounds.Y = value - Radius;
            }
        }

        protected int Radius
        {
            get { return (int)bounds.Width / 2; }
            set 
            { 
                bounds.Width = value * 2;
                bounds.Height = value * 2;
            }
        }

        #endregion


        #region Границы поля
        public int LeftSide => Radius;
        public int RightSide => form.ClientSize.Width - Radius;
        public int TopSide => Radius;
        public int BottomSide => form.ClientSize.Height - Radius;
        #endregion

        public Ball(Form form)
        {
            this.form = form;
            InitialRadius();
            InitialBounds();
            InitialTimer();
            InitialSpeed();
            InitialColor();
        }

        protected virtual void InitialColor()
        {
            color = Color.Coral;
        }

        protected virtual void InitialRadius() => Radius = 15;

        protected virtual void InitialSpeed()
        {
            vx = 10f;
            vy = 10f;
        }

        private void InitialTimer()
        {
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void InitialBounds()
        {
            Point point = GetPoint();
            Size size = new Size(Radius, Radius);

            bounds = new RectangleF(point, size);
        }

        public bool Contains(Point point) => bounds.Contains(point);

        protected virtual Point GetPoint() => new Point(150, 150);

        private void Timer_Tick(object sender, EventArgs e) => Move();

        public void Start() => timer.Start();

        public void Stop() => timer.Stop();

        public bool IsMovable() => timer.Enabled;

        public bool OnForm() => CenterX >= LeftSide && CenterX <= RightSide && CenterY >= TopSide && CenterY <= BottomSide;

        public void Move()
        {
            Clear();
            Go();
            Show();
        }
        protected virtual void Go() => bounds.Offset(vx, vy);

        public void Show() => Draw(color);

        public void Clear() => Draw(SystemColors.Control);

        private void Draw(Color color)
        {
            using (Brush brush = new SolidBrush(color))
            using (Graphics graphics = form.CreateGraphics())
            {
                graphics.FillEllipse(brush, bounds);
            }
        }

        public void Speed(SpeedBall slow)
        {
            switch (slow)
            {
                case SpeedBall.Slow: 
                    timer.Interval = 60;
                    break;
                case SpeedBall.Fast: 
                    timer.Interval = 10;
                    break;
                default:
                    timer.Interval = 20;
                    break;
            }
        }
    }
}
