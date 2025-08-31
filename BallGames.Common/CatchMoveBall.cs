using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class CatchMoveBall : MoveBall
    {
        public CatchMoveBall(Form form) : base(form) 
        {
            Radius = 25;
        }
        public bool Contains(Point point) => bounds.Contains(point);
    }
}
