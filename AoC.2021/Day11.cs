namespace AoC2021;

public class Day11 : Day
{
    public override string Title => "--- Day 11: Dumbo Octopus ---";

    public override void PartOne()
    {
        base.PartOne();
        var input = Input.ToStringList();

        var flashes = PlayOctopus(input, false);

        Console.WriteLine(flashes); // 1615
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var input = Input.ToStringList();

        var step = PlayOctopus(input, true);

        Console.WriteLine(step); // 249
    }

    private static int PlayOctopus(List<string> input, bool isPartTwo)
    {
        var octopi = new List<Octopus>();
        for (var y = 0; y < input.Count; y++)
        {
            for (var x = 0; x < input[y].Length; x++)
            {
                var newCoord = new Coordinate(x, y);

                var c = input[y][x];
                var octopus = new Octopus(newCoord, c - '0');
                octopi.Add(octopus);
            }
        }

        var iterations = isPartTwo ? 100000 : 100;
        var flashes = 0;
        for (var i = 0; i < iterations; i++)
        {
            octopi.ForEach(o => o.Step());

            foreach (var octopus in octopi)
            {
                octopus.TryFlash(octopi);
            }

            var flashed = octopi.Count(o => o.HaveFlashed);

            if (isPartTwo && flashed == octopi.Count)
            {
                var step = i + 1;
                return step;
            }

            flashes += flashed;
        }

        return flashes;
    }

    private static string Input = @"4738615556
6744423741
2812868827
8844365624
4546674266
4518674278
7457237431
4524873247
3153341314
3721414667";
}

file class Octopus
{
    public Coordinate Coordinate { get; }
    public int EnergyLevel { get; set; }

    public bool HaveFlashed { get; set; }

    public Octopus(Coordinate coordinate, int energyLevel)
    {
        Coordinate = coordinate;
        EnergyLevel = energyLevel;
    }

    public void Step()
    {
        HaveFlashed = false;
        EnergyLevel++;
    }

    public void TryFlash(List<Octopus> octopi)
    {
        if (HaveFlashed)
        {
            return;
        }

        if (EnergyLevel > 9)
        {
            HaveFlashed = true;

            var adjacent = octopi.Where(o => Coordinate.IsAdjacentPlusDiag(o.Coordinate));
            foreach (var o in adjacent)
            {
                o.BeAffected(octopi);
            }

            EnergyLevel = 0;
        }
    }

    public void BeAffected(List<Octopus> octopi)
    {
        if (HaveFlashed)
        {
            return;
        }

        EnergyLevel++;
        TryFlash(octopi);
    }
}