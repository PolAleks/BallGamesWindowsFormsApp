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

        public Ball(Form form)
        {
            this.form = form;
            graphics = form.CreateGraphics();
        }

        public void Show()
        {
            CreateBall(Color.LightBlue);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        private void Clear()
        {
            CreateBall(SystemColors.Control);
        }

        private void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        private void CreateBall(Color color)
        {
            var brush = new SolidBrush(color);
            var rectangle = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
