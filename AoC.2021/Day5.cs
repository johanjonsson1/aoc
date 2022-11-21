namespace AoC2021;

public class Day5 : Day
{
    public override string Title => "--- Day 5: Hydrothermal Venture ---";

    public override void PartOne()
    {
        base.PartOne();

        var allRows = Inputs.Day5.ToStringList();
        var groups = CalculatePoints(allRows, false);
        Console.WriteLine(groups.Count); // 7436
    }

    public override void PartTwo()
    {
        base.PartTwo();

        var allRows = Inputs.Day5.ToStringList();
        var groups = CalculatePoints(allRows, true);
        Console.WriteLine(groups.Count); // 21104
    }

    private static List<IGrouping<Coordinate, Coordinate>> CalculatePoints(List<string> allRows, bool allowDiagonal)
    {
        var points = new List<Coordinate>();
        foreach (var row in allRows)
        {
            var split = row.Split(' ');
            var firstXY = split[0].SplitAsIntsBy(',');
            var secondXY = split[2].SplitAsIntsBy(',');

            var firstX = firstXY[0];
            var firstY = firstXY[1];
            var secondX = secondXY[0];
            var secondY = secondXY[1];

            var negativeX = firstX > secondX;
            var negativeY = firstY > secondY;

            var isDiagonal = firstX != secondX && firstY != secondY;
            if (!allowDiagonal && isDiagonal)
            {
                continue;
            }

            var currentX = firstX;
            var currentY = firstY;
            while (true)
            {
                var point = new Coordinate(currentX, currentY);
                points.Add(point);

                if (currentX == secondX && currentY == secondY)
                {
                    break;
                }

                if (currentX != secondX)
                {
                    if (negativeX)
                    {
                        currentX--;
                    }
                    else
                    {
                        currentX++;
                    }
                }

                if (currentY != secondY)
                {
                    if (negativeY)
                    {
                        currentY--;
                    }
                    else
                    {
                        currentY++;
                    }
                }
            }
        }

        var groups = points.GroupBy(x => x).Where(g => g.Count() > 1).ToList();
        return groups;
    }

}