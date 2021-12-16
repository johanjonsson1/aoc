namespace AoC2016;

/*
--- Day 3: Squares With Three Sides ---
Now that you can think clearly, you move deeper into the labyrinth of hallways and office furniture that makes up this part of Easter Bunny HQ. 
This must be a graphic design department; the walls are covered in specifications for triangles.

Or are they?

The design document gives the side lengths of each triangle it describes, but... 5 10 25? Some of these aren't triangles. You can't help but mark the impossible ones.

In a valid triangle, the sum of any two sides must be larger than the remaining side. For example, the "triangle" given above is impossible, because 5 + 10 is not larger than 25.

In your puzzle input, how many of the listed triangles are possible?

Your puzzle answer was 982.

--- Part Two ---
Now that you've helpfully marked up their design documents, it occurs to you that triangles are specified in groups of three vertically. 
Each set of three numbers in a column specifies a triangle. Rows are unrelated.

For example, given the following specification, numbers with the same hundreds digit would be part of the same triangle:

101 301 501
102 302 502
103 303 503
201 401 601
202 402 602
203 403 603
In your puzzle input, and instead reading by columns, how many of the listed triangles are possible?

Your puzzle answer was 1826.
*/
public class Day3 : Day
{
    public override string Title => "--- Day 3: Squares With Three Sides ---";

    public override void PartOne()
    {
        base.PartOne();
        var triangles = Inputs.Day3.ToStringList().Select(s => s.SplitAsIntsBy(' ').OrderBy(o => o).ToList());
        var result = 0;

        foreach (var triangle in triangles)
        {
            var sum = (triangle[0] + triangle[1]);
            if (sum > triangle[2])
            {
                result++;
            }
        }

        Console.WriteLine(result);
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var trianglesCol = Inputs.Day3.ToStringList().Select(s => s.SplitAsIntsBy(' ')[0]).ToList();
        var trianglesCol2 = Inputs.Day3.ToStringList().Select(s => s.SplitAsIntsBy(' ')[1]).ToList();
        var trianglesCol3 = Inputs.Day3.ToStringList().Select(s => s.SplitAsIntsBy(' ')[2]).ToList();

        trianglesCol.AddRange(trianglesCol2);
        trianglesCol.AddRange(trianglesCol3);

        var result = 0;

        for (var i = 0; i < trianglesCol.Count; i += 3)
        {
            var triGrp = new List<int> { trianglesCol[i], trianglesCol[i + 1], trianglesCol[i + 2] }.OrderBy(o => o).ToList();

            var sum = (triGrp[0] + triGrp[1]);
            if (sum > triGrp[2])
            {
                result++;
            }
        }

        Console.WriteLine(result);
    }
}