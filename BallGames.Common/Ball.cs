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
        protected float vx = 10f;
        protected float vy = 10f;

        #region Параметры шара
        protected Color color = Color.Coral;
        protected float CenterX 
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
            
            InitialBounds();
            InitialTimer();
        }

        private void InitialTimer()
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void InitialBounds()
        {
            Point point = GetPoint();

            Radius = 15;
            Size size = new Size(Radius, Radius);

            bounds = new RectangleF(point, size);
        }

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

        protected void Clear() => Draw(SystemColors.Control);

        private void Draw(Color color)
        {
            using (Brush brush = new SolidBrush(color))
            using (Graphics graphics = form.CreateGraphics())
            {
                graphics.FillEllipse(brush, bounds);
            }
        }
    }
}
