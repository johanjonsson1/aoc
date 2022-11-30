namespace AoC.Common;

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

    public override string ToString()
    {
        return $"X: {X}, Y: {Y}";
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
        var result = Math.Atan2(deltaY, deltaX);

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
        var result = Math.Atan2(deltaY, deltaX);

        result = Math.Round((result * (180 / Math.PI)), 2);

        if (result < 90)
        {
            result = 360d + result;
        }

        return result;
    }

    public bool IsAdjacent(Coordinate other)
    {
        var x = this.X;
        var y = this.Y;

        return
            //(a.Coordinate.X == x - 1 && a.Coordinate.Y == y - 1) ||
            (other.X == x && other.Y == y - 1) ||
            //(a.Coordinate.X == x + 1 && a.Coordinate.Y == y - 1) ||
            (other.X == x + 1 && other.Y == y) ||
            (other.X == x - 1 && other.Y == y) ||
            //(a.Coordinate.X == x - 1 && a.Coordinate.Y == y + 1) ||
            (other.X == x && other.Y == y + 1); // ||
        //(a.Coordinate.X == x + 1 && a.Coordinate.Y == y + 1))
    }

    public bool IsAdjacentPlusDiag(Coordinate other)
    {
        var x = this.X;
        var y = this.Y;

        return
            (other.X == x - 1 && other.Y == y - 1) ||
            (other.X == x && other.Y == y - 1) ||
            (other.X == x + 1 && other.Y == y - 1) ||
            (other.X == x + 1 && other.Y == y) ||
            (other.X == x - 1 && other.Y == y) ||
            (other.X == x - 1 && other.Y == y + 1) ||
            (other.X == x && other.Y == y + 1) ||
            (other.X == x + 1 && other.Y == y + 1);
    }

    public IEnumerable<Coordinate> GetAdjacentPlusDiag()
    {
        yield return new Coordinate(X - 1, Y - 1); // lowerleft diag
        yield return new Coordinate(X + 1, Y - 1); // lowerright diag
        yield return new Coordinate(X + 1, Y); // right
        yield return new Coordinate(X, Y - 1); // down
        yield return new Coordinate(X - 1, Y); // left
        yield return new Coordinate(X - 1, Y + 1); // upperleft diag
        yield return new Coordinate(X, Y + 1); // up
        yield return new Coordinate(X + 1, Y + 1); // upperright diag
    }

    public IEnumerable<Coordinate> GetAllLowerLeft(int minX, int minY)
    {
        var x = X;
        var y = Y;

        while (x >= minX && y >= minY)
        {
            yield return new Coordinate(--x, --y);
        }
    }

    public IEnumerable<Coordinate> GetAllLowerRight(int maxX, int minY)
    {
        var x = X;
        var y = Y;

        while (x <= maxX && y >= minY)
        {
            yield return new Coordinate(++x, --y);
        }
    }

    public IEnumerable<Coordinate> GetAllRight(int maxX)
    {
        var x = X;
        while (x <= maxX)
        {
            yield return new Coordinate(++x, Y);
        }
    }

    public IEnumerable<Coordinate> GetAllLeft(int minX)
    {
        var x = X;
        while (x >= minX)
        {
            yield return new Coordinate(--x, Y);
        }
    }

    public IEnumerable<Coordinate> GetAllDown(int minY)
    {
        var y = Y;
        while (y >= minY)
        {
            yield return new Coordinate(X, --y);
        }
    }

    public IEnumerable<Coordinate> GetAllUp(int maxY)
    {
        var y = Y;
        while (y <= maxY)
        {
            yield return new Coordinate(X, ++y);
        }
    }


    public IEnumerable<Coordinate> GetAllUpperLeft(int minX, int maxY)
    {
        var x = X;
        var y = Y;

        while (x >= minX && y <= maxY)
        {
            yield return new Coordinate(--x, ++y);
        }
    }

    public IEnumerable<Coordinate> GetAllUpperRight(int maxX, int maxY)
    {
        var x = X;
        var y = Y;

        while (x <= maxY && y <= maxY)
        {
            yield return new Coordinate(++x, ++y);
        }
    }
}