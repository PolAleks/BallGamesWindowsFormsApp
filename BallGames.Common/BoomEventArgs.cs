using System;

namespace BallGames.Common
{
    public class BoomEventArgs : EventArgs
    {
        public int Count { get; }
        public float X { get; }
        public float Y { get; }
        public BoomEventArgs(int count, float x, float y)
        {
            Count = count;
            X = x;
            Y = y;
        }
    }
}