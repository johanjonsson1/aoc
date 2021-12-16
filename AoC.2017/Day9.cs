namespace AoC2017;

public class Day9 : IDay
{
    public string Title => "2017 Day9";
    public List<Garbage> GarbageList = new List<Garbage>();

    public void Run()
    {
        //var g1 = new Garbage("<!!>"); //0
        //Console.WriteLine(g1.SumOfAllGarbage);
        //var g2 = new Garbage("<{!>}>"); //2
        //Console.WriteLine(g2.SumOfAllGarbage);
        //var g3 = new Garbage("<<<<>"); // 3
        //Console.WriteLine(g3.SumOfAllGarbage);
        //var g4 = new Garbage("<{o\"i!a,<{i<a>"); //10
        //Console.WriteLine(g4.SumOfAllGarbage);

        //GarbageList.Add(g1);
        //GarbageList.Add(g2);
        //GarbageList.Add(g3);
        //GarbageList.Add(g4);

        //var sum = GarbageList.Sum(g => g.SumOfAllGarbage);
        //Console.WriteLine(sum);
        //return;

        var test = @"{}
{{{}}}, score of 1 + 2 + 3 = 6.
{{},{}}, score of 1 + 2 + 2 = 5.
{{{},{},{{}}}}, score of 1 + 2 + 3 + 3 + 3 + 4 = 16.
{<a>,<a>,<a>,<a>}, score of 1.
{{<ab>},{<ab>},{<ab>},{<ab>}}, score of 1 + 2 + 2 + 2 + 2 = 9.
{{<!!>},{<!!>},{<!!>},{<!!>}}, score of 1 + 2 + 2 + 2 + 2 = 9.
{{<a!>},{<a!>},{<a!>},{<ab>}}";
        //clean garbage
        //var input = "{{<ab>},{<!!!!>},{<ab>},{<ab>}}"; //16
        //var input = "{{<!!!!>>},,lk}}";
        //var input = "{{<a!>},{<a!>},{<a!>},{<ab>}}";//"{{{},{},{{}}}}"; //"{{<ab>},{<ab>},{<ab>},{<ab>}}"; //"{{{}}}";
        var input = Inputs.Day9;
        string aa = input;

        bool garbageRemoved = true;
        while (garbageRemoved)
        {
            garbageRemoved = TryCleanGarbage(aa, out aa);
        }

        var score = 0;
        bool scoreFound = true;
        while (scoreFound)
        {
            var score2 = 0;
            scoreFound = TryCalculateScore(aa, out aa, out score2);
            score += score2;
        }

        Console.WriteLine(score);
        Console.WriteLine(aa);
        var sum = GarbageList.Sum(g => g.SumOfAllGarbage);
        Console.WriteLine(sum);
    }

    private bool TryCalculateScore(string input, out string output, out int score)
    {
        var innerMostScoreStartIndex = -1;
        var innerMostScoreEndIndex = -1;
        var nestCounter = 0;
        var nextCharInvalid = false;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '{' && nextCharInvalid == false)
            {
                innerMostScoreStartIndex = i;
                nestCounter++;
            }

            if (input[i] == '}' && innerMostScoreStartIndex != -1 && i > innerMostScoreStartIndex && nextCharInvalid == false)
            {
                innerMostScoreEndIndex = i;
            }

            if (innerMostScoreStartIndex > -1 && innerMostScoreEndIndex > -1)
            {
                output = input.Remove(innerMostScoreStartIndex, innerMostScoreEndIndex - innerMostScoreStartIndex + 1);

                score = nestCounter;
                return true;
            }

            if (input[i] == '!' && nextCharInvalid == false)
            {
                nextCharInvalid = true;
            }
            else
            {
                nextCharInvalid = false;
            }
        }

        output = input;
        score = nestCounter;
        return false;
    }

    private bool TryCleanGarbage(string input, out string output)
    {
        var garbageStartIndex = -1;
        var garbageEndIndex = -1;
        var nextCharInvalid = false;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '<' && garbageStartIndex == -1 && nextCharInvalid == false)
            {
                garbageStartIndex = i;
            }

            if (input[i] == '>' && garbageStartIndex != -1 && i > garbageStartIndex && nextCharInvalid == false)
            {
                garbageEndIndex = i;
            }

            if (garbageStartIndex > -1 && garbageEndIndex > -1)
            {
                var temp = input.Substring(garbageStartIndex, garbageEndIndex - garbageStartIndex + 1);
                //Console.WriteLine("Removing " + temp);
                GarbageList.Add(new Garbage(temp));

                output = input.Remove(garbageStartIndex, garbageEndIndex - garbageStartIndex + 1);
                return true;
            }

            if (input[i] == '!' && nextCharInvalid == false)
            {
                nextCharInvalid = true;
            }
            else
            {
                nextCharInvalid = false;
            }
        }

        output = input;
        return false;
    }
}

public class Garbage
{
    public string Characters { get; private set; }

    public Garbage(string input)
    {
        Characters = input;
    }

    public int SumOfAllGarbage
    {
        get
        {
            var sum = 0;
            var nextCharInvalid = false;
            var trimmed = Characters.Remove(Characters.Length - 1, 1).Remove(0, 1);

            for (int i = 0; i < trimmed.Length; i++)
            {
                if (nextCharInvalid == false)
                {
                    sum++;
                }

                if (trimmed[i] == '!' && nextCharInvalid == false)
                {
                    nextCharInvalid = true;
                    sum--;
                }
                else
                {
                    nextCharInvalid = false;
                }
            }

            return sum;
        }
    }
}