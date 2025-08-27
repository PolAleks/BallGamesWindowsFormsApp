using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balls.Common
{
    public class Ball
    {
        protected Form form;
        protected Graphics graphics;

        protected int centerX = 150;
        protected int centerY = 150;
        protected int radius = 30;

        protected int vx = 10;
        protected int vy = 10;

        public int LeftSide => radius;

        public int RightSide => form.ClientSize.Width - radius;

        public int TopSide => radius;

        public int BottomSide => form.ClientSize.Height - radius;

        public Ball(Form form)
        {
            this.form = form;
            graphics = form.CreateGraphics();
        }

        public void Show()
        {
            Draw(Color.LightBlue);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        private void Clear()
        {
            Draw(SystemColors.Control);
        }

        private void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        private void Draw(Color color)
        {
            var brush = new SolidBrush(color);
            var rectangle = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
