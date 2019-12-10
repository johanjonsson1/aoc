using System;
using System.Collections.Generic;

namespace AoC.Common
{
    public struct Coordinate : IEquatable<Coordinate>
    {
        private sealed class XYEqualityComparer : IEqualityComparer<Coordinate>
        {
            public bool Equals(Coordinate x, Coordinate y)
            {
                return x.X == y.X && x.Y == y.Y;
            }

            public int GetHashCode(Coordinate obj)
            {
                unchecked
                {
                    return (obj.X * 397) ^ obj.Y;
                }
            }
        }

        public static IEqualityComparer<Coordinate> CoordinateComparer { get; } = new XYEqualityComparer();

        public int X;
        public int Y;

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            return obj is Coordinate coordinate &&
                   X == coordinate.X &&
                   Y == coordinate.Y;
        }

        public bool Equals(Coordinate other)
        {
            return X == other.X &&
                   Y == other.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() + Y.GetHashCode();
        }

        public int GetDistance(Coordinate other)
        {
            return Math.Abs(X - other.X) + Math.Abs(Y - other.Y);
        }

        public double GetAngle(Coordinate other)
        {
            double deltaY = (Y - other.Y);
            double deltaX = (X - other.X);
            double result = Math.Atan2(deltaY, deltaX);

            result = Math.Round((result * (180 / Math.PI)), 2);

            if (result < 0)
            {
                result = 360d + result;
            }

            return result;
        }

        public double GetAngle90DegreesOffset(Coordinate other)
        {
            double deltaY = (Y - other.Y);
            double deltaX = (X - other.X);
            double result = Math.Atan2(deltaY, deltaX);

            result = Math.Round((result * (180 / Math.PI)), 2);

            if (result < 90)
            {
                result = 360d + result;
            }

            return result;
        }
    }
}