using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGamesWindowsFormsApp
{
    public class Ball
    {
        protected FormMain form;
        protected Graphics graphics;

        public int x = 150;
        public int y = 150;
        protected int vx = 10;
        protected int vy = 10;
        protected int size = 60;

        public Ball(FormMain formMain)
        {
            form = formMain;
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
            x += vx;
            y += vy;
        }

        private void CreateBall(Color color)
        {
            var brush = new SolidBrush(color);
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
