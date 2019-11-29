using System;

namespace AoC.Common
{
    public class Point<T> where T : class
    {
        public Coordinate Coordinate { get; }

        public T Item { get; set; }

        public Point(int x, int y, T item)
        {
            Coordinate = new Coordinate(x, y);
            Item = item;
        }

        public int GetDistance(Point<T> other)
        {
            return Math.Abs(Coordinate.X - other.Coordinate.X) + Math.Abs(Coordinate.Y - other.Coordinate.Y);
        }
    }
}