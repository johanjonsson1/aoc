namespace AoC2015;

/*
    --- Day 3: Perfectly Spherical Houses in a Vacuum ---

    Santa is delivering presents to an infinite two-dimensional grid of houses.

    He begins by delivering a present to the house at his starting location, 
    and then an elf at the North Pole calls him via radio and tells him where to move next. 
    Moves are always exactly one house to the north (^), south (v), east (>), or west (<). 
    After each move, he delivers another present to the house at his new location.

    However, the elf back at the north pole has had a little too much eggnog, 
    and so his directions are a little off, and Santa ends up visiting some houses more than once. 
    How many houses receive at least one present?

    For example:

    > delivers presents to 2 houses: one at the starting location, and one to the east.
    ^>v< delivers presents to 4 houses in a square, including twice to the house at his starting/ending location.
    ^v^v^v^v^v delivers a bunch of presents to some very lucky children at only 2 houses.

    --- Part Two ---

    The next year, to speed up the process, Santa creates a robot version of himself, Robo-Santa, to deliver presents with him.

    Santa and Robo-Santa start at the same location (delivering two presents to the same starting house), 
    then take turns moving based on instructions from the elf, who is eggnoggedly reading from the same script as the previous year.

    This year, how many houses receive at least one present?

    For example:

    ^v delivers presents to 3 houses, because Santa goes north, and then Robo-Santa goes south.
    ^>v< now delivers presents to 3 houses, and Santa and Robo-Santa end up back where they started.
    ^v^v^v^v^v now delivers presents to 11 houses, with Santa going one direction and Robo-Santa going the other.
 */
public class Day3 : IDay
{
    public string Title => "Day 3";

    public void Run()
    {
        PartOne();
        PartTwo();
    }

    private void PartOne()
    {
        var x = 0;
        var y = 0;

        var visitedPlaces = new List<PointXy>();

        visitedPlaces.Add(new PointXy { X = x, Y = y });

        foreach (var direction in Inputs.Day3)
        {
            switch (direction)
            {
                case '>':
                    x++;
                    break;
                case '<':
                    x--;
                    break;
                case '^':
                    y++;
                    break;
                case 'v':
                    y--;
                    break;
            }

            visitedPlaces.Add(new PointXy { X = x, Y = y });
        }

        var places = visitedPlaces.Distinct(new PointXyComparer()).ToList();

        Console.WriteLine(places.Count);
    }

    private void PartTwo()
    {
        var santa1X = 0;
        var santa1Y = 0;
        var robosantax = 0;
        var robosantay = 0;

        var visitedPlaces1 = new List<PointXy>();
        var visitedPlaces2 = new List<PointXy>();

        visitedPlaces1.Add(new PointXy { X = santa1X, Y = santa1Y });
        visitedPlaces1.Add(new PointXy { X = robosantax, Y = robosantay });

        var santa1Directions = Inputs.Day3.Where((value, index) => index % 2 == 0).ToArray();
        var robosantaDirections = Inputs.Day3.Where((value, index) => index % 2 == 1).ToArray();

        foreach (var direction in santa1Directions)
        {
            switch (direction)
            {
                case '>':
                    santa1X++;
                    break;
                case '<':
                    santa1X--;
                    break;
                case '^':
                    santa1Y++;
                    break;
                case 'v':
                    santa1Y--;
                    break;
            }

            visitedPlaces1.Add(new PointXy { X = santa1X, Y = santa1Y });
        }

        foreach (var direction in robosantaDirections)
        {
            switch (direction)
            {
                case '>':
                    robosantax++;
                    break;
                case '<':
                    robosantax--;
                    break;
                case '^':
                    robosantay++;
                    break;
                case 'v':
                    robosantay--;
                    break;
            }

            visitedPlaces2.Add(new PointXy { X = robosantax, Y = robosantay });
        }

        var places = visitedPlaces1.Union(visitedPlaces2, new PointXyComparer()).ToList();

        Console.WriteLine(places.Count);

    }
}

public class PointXy
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class PointXyComparer : IEqualityComparer<PointXy>
{
    public bool Equals(PointXy one, PointXy two)
    {
        if (one == null && two == null)
            return true;
        else if (one == null || two == null)
            return false;
        else if (one.X == two.X && one.Y == two.Y)
            return true;
        else
            return false;
    }

    public int GetHashCode(PointXy obj)
    {
        var hCode = obj.X ^ obj.Y;
        return hCode.GetHashCode();
    }
}