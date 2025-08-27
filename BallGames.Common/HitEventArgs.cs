using System;

namespace BallGames.Common
{
    public class HitEventArgs : EventArgs
    {
        public Side Side;

        public HitEventArgs(Side side)
        {
            Side = side;
        }
    }
}
