namespace AoC2017;
/*
--- Day 16: Permutation Promenade ---
You come upon a very unusual sight; a group of programs here appear to be dancing.

There are sixteen programs in total, named a through p. 
They start by standing in a line: a stands in position 0, b stands in position 1, and so on until p, which stands in position 15.

The programs' dance consists of a sequence of dance moves:

Spin, written sX, makes X programs move from the end to the front, but maintain their order otherwise. 
(For example, s3 on abcde produces cdeab).
Exchange, written xA/B, makes the programs at positions A and B swap places.
Partner, written pA/B, makes the programs named A and B swap places.
For example, with only five programs standing in a line (abcde), they could do the following dance:

s1, a spin of size 1: eabcd.
x3/4, swapping the last two programs: eabdc.
pe/b, swapping programs e and b: baedc.
After finishing their dance, the programs end up in order baedc.

You watch the dance for a while and record their dance moves (your puzzle input). 
In what order are the programs standing after their dance?

Your puzzle answer was bkgcdefiholnpmja.

--- Part Two ---
Now that you're starting to get a feel for the dance moves, you turn your attention to the dance as a whole.

Keeping the positions they ended up in from their previous dance, the programs perform it again and again: including the first dance, a total of one billion (1000000000) times.

In the example above, their second dance would begin with the order baedc, and use the same dance moves:

s1, a spin of size 1: cbaed.
x3/4, swapping the last two programs: cbade.
pe/b, swapping programs e and b: ceadb.
In what order are the programs standing after their billion dances?

Your puzzle answer was knmdfoijcbpghlea.
*/

public class Day16 : Day
{
    public override string Title => "--- Day 16: Permutation Promenade ---";
    //public static string Order = "abcde";
    public static string Order = "abcdefghijklmnop";

    public override void PartOne()
    {
        base.PartOne();
        //            var input = @"s1
        //x3/4
        //pe/b".ToStringList();

        var danceMachine = new DanceMachine();

        foreach (var move in Inputs.Day16.Split(','))
        {
            Order = danceMachine.DanceMove(move, Order);
        }

        Console.WriteLine("Result part 1");
        Console.WriteLine(Order);
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var danceMachine = new DanceMachine();
        var moves = Inputs.Day16.Split(',');
        var length = moves.Length;
        var combinations = new List<string> { Order };

        var billion = 1;
        while (billion < 1_000_000_000)
        {
            var counter = 0;

            while (counter < length)
            {
                var move = moves[counter];
                Order = danceMachine.DanceMove(move, Order);
                counter++;
            }

            if (combinations.Contains(Order))
            {
                var index = 1_000_000_000 % billion;
                var key = combinations[index - 1];
                Order = key;
                break;
            }

            combinations.Add(Order);

            billion++;
        }

        Console.WriteLine("Result part 2");
        Console.WriteLine(Order);
    }
}

public class DanceMachine
{
    private LinkedList<char> _orderLinkedList;

    public string DanceMove(string danceMove, string currentOrder)
    {
        _orderLinkedList = new LinkedList<char>(currentOrder);

        if (danceMove.StartsWith("s"))
        {
            Spin(int.Parse(danceMove.RemoveAToZ()));
        }
        else if (danceMove.StartsWith("x"))
        {
            Exchange(danceMove.RemoveAToZ().SplitAsIntsBy('/'));
        }
        else if (danceMove.StartsWith("p"))
        {
            Swap(danceMove.Substring(1, danceMove.Length - 1));
        }

        return string.Join("", _orderLinkedList.ToArray());
    }

    private void Spin(int times)
    {
        for (var i = 0; i < times; i++)
        {
            var last = _orderLinkedList.Last();
            _orderLinkedList.RemoveLast();
            _orderLinkedList.AddFirst(last);
        }
    }

    private void Exchange(List<int> positions)
    {
        var firstChar = _orderLinkedList.ElementAt(positions.First());
        var secondChar = _orderLinkedList.ElementAt(positions.Last());

        Swap(firstChar + " " + secondChar);
    }

    private void Swap(string names)
    {
        var a = names[0];
        var b = names[2];
        if (a == b)
        {
            return;
        }

        var first = _orderLinkedList.Find(a);
        var second = _orderLinkedList.Find(b);
        _orderLinkedList.AddAfter(first, new LinkedListNode<char>(b));
        _orderLinkedList.AddAfter(second, new LinkedListNode<char>(a));
        _orderLinkedList.Remove(first);
        _orderLinkedList.Remove(second);
    }
}