namespace AoC.Common;

public struct Coordinate3D : IEquatable<Coordinate3D>
{
    public int X;
    public int Y;
    public int Z;

    public Coordinate3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override bool Equals(object obj)
    {
        return obj is Coordinate3D coordinate &&
               X == coordinate.X &&
               Y == coordinate.Y &&
               Z == coordinate.Z;
    }

    public bool Equals(Coordinate3D other)
    {
        return X == other.X &&
               Y == other.Y &&
               Z == other.Z;
    }

    public override int GetHashCode()
    {
        return X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode();
    }

    public int GetDistance(Coordinate3D other)
    {
        return Math.Abs(X - other.X) + Math.Abs(Y - other.Y) + Math.Abs(Z - other.Z);
    }
}