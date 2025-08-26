using BallGamesWindowsFormsApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGames.Common
{
    public class CatchMoveBall : MoveBall
    {
        private int Radius => size / 2;
        private int X => x + Radius;
        private int Y => y + Radius;

        public CatchMoveBall(Form form) : base(form) { }

        public bool Contains(Point p) => Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2)) <= Radius;
    }
}
