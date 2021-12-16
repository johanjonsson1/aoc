namespace AoC2020;

public class Day7 : Day
{
    public override string Title => "day 7";

    public override void PartOne()
    {
        base.PartOne();
        var input1 = @"light red bags contain 1 bright white bag, 2 muted yellow bags.
dark orange bags contain 3 bright white bags, 4 muted yellow bags.
bright white bags contain 1 shiny gold bag.
muted yellow bags contain 2 shiny gold bags, 9 faded blue bags.
shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.
dark olive bags contain 3 faded blue bags, 4 dotted black bags.
vibrant plum bags contain 5 faded blue bags, 6 dotted black bags.
faded blue bags contain no other bags.
dotted black bags contain no other bags.";

        var input = Inputs.Day7.ToStringList();

        var allBags = new List<ColoredBag>();

        foreach (var line in input)
        {
            var line2 = line.Replace("bags", "").Replace("bag", "").Replace(".", "").Trim();
            var split = line2.Split("contain", StringSplitOptions.RemoveEmptyEntries);
            allBags.Add(new ColoredBag(split[0], split[1]));
        }

        while (allBags.Any(b => !b.Fulfilled))
        {
            foreach (var coloredBag in allBags.Where(b => !b.Fulfilled))
            {
                for (var i = coloredBag.Target.Count - 1; i >= 0; i--)
                {
                    var (id, quantity) = coloredBag.Target[i];
                    var matchingFulfilledBag = allBags.FirstOrDefault(x => x.Id == id && x.Fulfilled);

                    if (matchingFulfilledBag == null)
                    {
                        continue;
                    }

                    coloredBag.Target.RemoveAt(i);
                    for (var q = 0; q < quantity; q++)
                    {
                        coloredBag.Bags.Add(matchingFulfilledBag);
                    }

                    if (matchingFulfilledBag.ContainsGold)
                    {
                        coloredBag.ContainsGold = true;
                    }
                }
            }
        }

        var result = allBags.Where(b => b.ContainsGold).ToList();

        Console.WriteLine(result.Count);

        var result2 = allBags.Single(s => s.Id == "shiny gold");

        Console.WriteLine(result2.TotalBags);
    }

    public override void PartTwo()
    {
        base.PartTwo();
    }

    public class ColoredBag
    {
        public string Id;
        public string Color;
        public string ColorProperty;
        public bool ContainsGold { get; set; }
        public int TotalBags => Bags.Sum(x => x.TotalBags) + Bags.Count;

        public List<ColoredBag> Bags = new List<ColoredBag>();
        public List<(string id, int quantity)> Target = new List<(string id, int quantity)>();

        public bool Fulfilled => Target.Count == 0;

        public ColoredBag(string id, string containsBags)
        {
            Id = id.Trim();
            var strings = id.Split(' ');
            ColorProperty = strings[0];
            Color = strings.Length > 1 ? strings[1] : null;

            if (containsBags.Contains("no other"))
            {
                return;
            }

            var bagsAndQuantity = containsBags.Split(',', StringSplitOptions.RemoveEmptyEntries);

            foreach (var s in bagsAndQuantity)
            {
                var quantity = int.Parse(s.RemoveNonNumeric());
                var bagId = s.Remove0To9().Trim();

                Target.Add((bagId, quantity));

                if (bagId == "shiny gold")
                {
                    ContainsGold = true;
                }
            }
        }

        public override string ToString()
        {
            return $"{Id}, bags ({Bags.Count}), fulfilled {Fulfilled}";
        }
    }
}