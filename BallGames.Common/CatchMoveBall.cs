using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balls.Common
{
    public class CatchMoveBall : MoveBall
    {
        public CatchMoveBall(Form form) : base(form) { }

        public bool Contains(Point p) => Math.Sqrt(Math.Pow(centerX - p.X, 2) + Math.Pow(centerY - p.Y, 2)) <= radius;
    }
}
