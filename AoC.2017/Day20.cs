namespace AoC2017;
/*
--- Day 20: Particle Swarm ---
Suddenly, the GPU contacts you, asking for help. Someone has asked it to simulate too many particles, and it won't be able to finish them all in time to render the next frame at this rate.

It transmits to you a buffer (your puzzle input) listing each particle in order (starting with particle 0, then particle 1, particle 2, and so on). 
For each particle, it provides the X, Y, and Z coordinates for the particle's position (p), velocity (v), and acceleration (a), each in the format <X,Y,Z>.

Each tick, all particles are updated simultaneously. A particle's properties are updated in the following order:

Increase the X velocity by the X acceleration.
Increase the Y velocity by the Y acceleration.
Increase the Z velocity by the Z acceleration.
Increase the X position by the X velocity.
Increase the Y position by the Y velocity.
Increase the Z position by the Z velocity.
Because of seemingly tenuous rationale involving z-buffering, the GPU would like to know which particle will stay closest to position <0,0,0> in the long term. 
Measure this using the Manhattan distance, which in this situation is simply the sum of the absolute values of a particle's X, Y, and Z position.

For example, suppose you are only given two particles, both of which stay entirely on the X-axis (for simplicity). 
Drawing the current states of particles 0 and 1 (in that order) with an adjacent a number line and diagram of current X positions (marked in parentheses), the following would take place:

p=< 3,0,0>, v=< 2,0,0>, a=<-1,0,0>    -4 -3 -2 -1  0  1  2  3  4
p=< 4,0,0>, v=< 0,0,0>, a=<-2,0,0>                         (0)(1)

p=< 4,0,0>, v=< 1,0,0>, a=<-1,0,0>    -4 -3 -2 -1  0  1  2  3  4
p=< 2,0,0>, v=<-2,0,0>, a=<-2,0,0>                      (1)   (0)

p=< 4,0,0>, v=< 0,0,0>, a=<-1,0,0>    -4 -3 -2 -1  0  1  2  3  4
p=<-2,0,0>, v=<-4,0,0>, a=<-2,0,0>          (1)               (0)

p=< 3,0,0>, v=<-1,0,0>, a=<-1,0,0>    -4 -3 -2 -1  0  1  2  3  4
p=<-8,0,0>, v=<-6,0,0>, a=<-2,0,0>                         (0)   
At this point, particle 1 will never be closer to <0,0,0> than particle 0, and so, in the long run, particle 0 will stay closest.

Which particle will stay closest to position <0,0,0> in the long term?

Your puzzle answer was 258.

--- Part Two ---
To simplify the problem further, the GPU would like to remove any particles that collide. Particles collide if their positions ever exactly match. 
Because particles are updated simultaneously, more than two particles can collide at the same time and place. Once particles collide, they are removed and cannot collide with anything else after that tick.

For example:

p=<-6,0,0>, v=< 3,0,0>, a=< 0,0,0>    
p=<-4,0,0>, v=< 2,0,0>, a=< 0,0,0>    -6 -5 -4 -3 -2 -1  0  1  2  3
p=<-2,0,0>, v=< 1,0,0>, a=< 0,0,0>    (0)   (1)   (2)            (3)
p=< 3,0,0>, v=<-1,0,0>, a=< 0,0,0>

p=<-3,0,0>, v=< 3,0,0>, a=< 0,0,0>    
p=<-2,0,0>, v=< 2,0,0>, a=< 0,0,0>    -6 -5 -4 -3 -2 -1  0  1  2  3
p=<-1,0,0>, v=< 1,0,0>, a=< 0,0,0>             (0)(1)(2)      (3)   
p=< 2,0,0>, v=<-1,0,0>, a=< 0,0,0>

p=< 0,0,0>, v=< 3,0,0>, a=< 0,0,0>    
p=< 0,0,0>, v=< 2,0,0>, a=< 0,0,0>    -6 -5 -4 -3 -2 -1  0  1  2  3
p=< 0,0,0>, v=< 1,0,0>, a=< 0,0,0>                       X (3)      
p=< 1,0,0>, v=<-1,0,0>, a=< 0,0,0>

------destroyed by collision------    
------destroyed by collision------    -6 -5 -4 -3 -2 -1  0  1  2  3
------destroyed by collision------                      (3)         
p=< 0,0,0>, v=<-1,0,0>, a=< 0,0,0>
In this example, particles 0, 1, and 2 are simultaneously destroyed at the time and place marked X. On the next tick, particle 3 passes through unharmed.

How many particles are left after all collisions are resolved?

Your puzzle answer was 707.
*/

public class Day20 : Day
{
    public override string Title => "--- Day 20: Particle Swarm ---";

    public override void PartOne()
    {
        base.PartOne();
        //            var input = @"p=< 3,0,0>, v=< 2,0,0>, a=<-1,0,0>
        //p=< 4,0,0>, v=< 0,0,0>, a=<-2,0,0>".ToStringList();
        var input = Inputs.Day20.ToStringList();

        var zero = new Point3D<MovingPoint>(0, 0, 0, new MovingPoint(-1, new int[] { }, new int[] { }));
        List<Point3D<MovingPoint>> allPoints = CreatePoints(input);

        var closest = new List<int>();

        for (int i = 0; i < 10000; i++)
        {
            Parallel.ForEach(allPoints, (p) => p.MoveTick());

            var currentlyClosest = allPoints.OrderBy(o => o.GetDistance(zero)).First();
            closest.Add(currentlyClosest.Item.Id);
        }

        var winner = closest.GroupBy(g => g).OrderByDescending(o => o.Count()).Take(2);

        Console.WriteLine(winner.First().Count());
        Console.WriteLine(winner.Last().Count());
        Console.WriteLine("Winner: " + winner.First().Key); // 258
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var input = Inputs.Day20.ToStringList();

        var zero = new Point3D<MovingPoint>(0, 0, 0, new MovingPoint(-1, new int[] { }, new int[] { }));
        List<Point3D<MovingPoint>> allPoints = CreatePoints(input);

        for (int i = 0; i < 1000; i++)
        {
            Parallel.ForEach(allPoints.Where(ap => !ap.Item.Destroyed), (p) => p.MoveTick());

            Parallel.ForEach(allPoints.Where(ap => !ap.Item.Destroyed), (p) =>
            {
                foreach (var point in allPoints)
                {
                    if (point == p)
                    {
                        continue;
                    }

                    if (p.GetDistance(point) == 0)
                    {
                        p.Item.Destroy();
                        point.Item.Destroy();
                    }
                }
            });
        }

        var living = allPoints.Where(a => !a.Item.Destroyed).ToList();
        Console.WriteLine("Count: " + living.Count); // 707
    }

    private static List<Point3D<MovingPoint>> CreatePoints(List<string> input)
    {
        var allPoints = new List<Point3D<MovingPoint>>();

        var nameCounter = 0;
        foreach (var line in input)
        {
            var parts = line
                .Replace("p=<", "")
                .Replace(">, v=<", " ")
                .Replace(">, a=<", " ")
                .Replace('>', ' ')
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var points = parts[0].SplitAsIntsBy(',');
            var v = parts[1].SplitAsIntsBy(',');
            var a = parts[2].SplitAsIntsBy(',');

            allPoints.Add(
                new Point3D<MovingPoint>(
                    points[0],
                    points[1],
                    points[2],
                    new MovingPoint(nameCounter, v.ToArray(), a.ToArray())
                ));

            nameCounter++;
        }

        return allPoints;
    }
}

public static class MovingPointExtensions
{
    public static void MoveTick(this Point3D<MovingPoint> point)
    {
        point.Item.VelocityXyz[0] += point.Item.AccelerationXyz[0];
        point.Item.VelocityXyz[1] += point.Item.AccelerationXyz[1];
        point.Item.VelocityXyz[2] += point.Item.AccelerationXyz[2];

        point.SetNewCoordinates(
            point.Coordinate.X + point.Item.VelocityXyz[0],
            point.Coordinate.Y + point.Item.VelocityXyz[1],
            point.Coordinate.Z + point.Item.VelocityXyz[2]);
    }
}

public class MovingPoint
{
    public int Id { get; }
    public int[] VelocityXyz { get; }
    public int[] AccelerationXyz { get; }
    public bool Destroyed { get; private set; } = false;

    public MovingPoint(int id, int[] velocity, int[] acceleration)
    {
        Id = id;
        VelocityXyz = velocity;
        AccelerationXyz = acceleration;
    }

    public void Destroy()
    {
        Destroyed = true;
    }
}