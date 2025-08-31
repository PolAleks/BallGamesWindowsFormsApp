using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class CatchMoveBall : MoveBall
    {
        public CatchMoveBall(Form form) : base(form) 
        {
            
        }
        protected override void InitialRadius()
        {
            Radius = 40;
        }
    }
}
