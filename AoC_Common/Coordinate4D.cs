using System;

namespace AoC_Common
{

    public struct Coordinate4D : IEquatable<Coordinate4D>
    {
        public int X;
        public int Y;
        public int Z;
        public int T;

        public Coordinate4D(int x, int y, int z, int t)
        {
            X = x;
            Y = y;
            Z = z;
            T = t;
        }

        public override bool Equals(object obj)
        {
            return obj is Coordinate4D coordinate &&
                   X == coordinate.X &&
                   Y == coordinate.Y &&
                   Z == coordinate.Z &&
                   T == coordinate.T;
        }

        public bool Equals(Coordinate4D other)
        {
            return X == other.X &&
                   Y == other.Y &&
                   Z == other.Z &&
                   T == other.T;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode() + T.GetHashCode();
        }

        public int GetDistance(Coordinate4D other)
        {
            return Math.Abs(X - other.X) + Math.Abs(Y - other.Y) + Math.Abs(Z - other.Z) + Math.Abs(T - other.T);
        }
    }
}