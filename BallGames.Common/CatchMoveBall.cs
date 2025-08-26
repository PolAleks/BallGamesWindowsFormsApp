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
        private int X => x + size / 2;
        private int Y => y + size / 2;

        public CatchMoveBall(Form form) : base(form)
        {
        }

        public bool Catch(Point point)
        {
            var distanse = Math.Sqrt(Math.Pow(X - point.X, 2) + Math.Pow(Y - point.Y, 2));
            return distanse <= size / 2;
        }

        public bool OnMove() => IsMovable();
    }
}
