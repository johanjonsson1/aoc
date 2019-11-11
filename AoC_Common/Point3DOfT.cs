using System;

namespace AoC_Common
{

    public class Point3D<T> where T : class
    {
        public Coordinate3D Coordinate { get; private set; }

        public T Item { get; set; }

        public Point3D(int x, int y, int z, T item)
        {
            Coordinate = new Coordinate3D(x, y, z);
            Item = item;
        }

        public int GetDistance(Point3D<T> other)
        {
            return Math.Abs(Coordinate.X - other.Coordinate.X) + Math.Abs(Coordinate.Y - other.Coordinate.Y) + Math.Abs(Coordinate.Z - other.Coordinate.Z);
        }

        public void SetNewCoordinates(int x, int y, int z)
        {
            Coordinate = new Coordinate3D(x, y, z);
        }
    }
}