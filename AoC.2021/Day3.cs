namespace AoC2021;

public class Day3 : Day
{
    public override string Title => "--- Day 3: Binary Diagnostic ---";

    public override void PartOne()
    {
        base.PartOne();
        var inputs = Inputs.Day3.ToStringList()
            .ToColumns()
            .Select(s => s.Value
                .GroupBy(g => g)
                .OrderByDescending(o => o.Count())
                .First().Key);

        var gamma = Convert.ToInt32(new string(inputs.ToArray()), 2);
        var epsilon = gamma ^ Convert.ToInt32("111111111111", 2);

        Console.WriteLine(gamma * epsilon); // 4006064
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var inputs = Inputs.Day3.ToStringList();

        var colCount = inputs[0].Length;

        var oxyList = new List<string>(inputs);
        for (var i = 0; i < colCount; i++)
        {
            var ones = new List<string>();
            var zeros = new List<string>();

            foreach (var s in oxyList)
            {
                if (s[i] == '1')
                {
                    ones.Add(s);
                }
                else
                {
                    zeros.Add(s);
                }
            }

            oxyList = ones.Count >= zeros.Count ? ones : zeros;

            if (oxyList.Count == 1)
            {
                break;
            }
        }

        var co2List = new List<string>(inputs);

        for (var i = 0; i < colCount; i++)
        {
            var ones = new List<string>();
            var zeros = new List<string>();

            foreach (var s in co2List)
            {
                if (s[i] == '1')
                {
                    ones.Add(s);
                }
                else
                {
                    zeros.Add(s);
                }
            }

            co2List = zeros.Count <= ones.Count ? zeros : ones;

            if (co2List.Count == 1)
            {
                break;
            }
        }

        var oxy = Convert.ToInt32(new string(oxyList.Single().ToArray()), 2);
        var co2 = Convert.ToInt32(new string(co2List.Single().ToArray()), 2);
        var result = oxy * co2;
        Console.WriteLine(result); // 5941884
    }
}