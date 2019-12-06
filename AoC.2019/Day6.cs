using AoC.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC2019
{
    /*
    --- Day 6: Universal Orbit Map ---
    You've landed at the Universal Orbit Map facility on Mercury. 
    Because navigation in space often involves transferring between orbits, the orbit maps here are useful for finding efficient routes between, for example, you and Santa. 
    You download a map of the local orbits (your puzzle input).

    Except for the universal Center of Mass (COM), every object in space is in orbit around exactly one other object. An orbit looks roughly like this:

                      \
                       \
                        |
                        |
    AAA--> o            o <--BBB
                        |
                        |
                       /
                      /
    In this diagram, the object BBB is in orbit around AAA. The path that BBB takes around AAA (drawn with lines) is only partly shown. 
    In the map data, this orbital relationship is written AAA)BBB, which means "BBB is in orbit around AAA".

    Before you use your map data to plot a course, you need to make sure it wasn't corrupted during the download. 
    To verify maps, the Universal Orbit Map facility uses orbit count checksums - the total number of direct orbits (like the one shown above) and indirect orbits.

    Whenever A orbits B and B orbits C, then A indirectly orbits C. 
    This chain can be any number of objects long: if A orbits B, B orbits C, and C orbits D, then A indirectly orbits D.

    For example, suppose you have the following map:

    COM)B
    B)C
    C)D
    D)E
    E)F
    B)G
    G)H
    D)I
    E)J
    J)K
    K)L
    Visually, the above map of orbits looks like this:

            G - H       J - K - L
           /           /
    COM - B - C - D - E - F
                   \
                    I
    In this visual representation, when two objects are connected by a line, the one on the right directly orbits the one on the left.

    Here, we can count the total number of orbits as follows:

    D directly orbits C and indirectly orbits B and COM, a total of 3 orbits.
    L directly orbits K and indirectly orbits J, E, D, C, B, and COM, a total of 7 orbits.
    COM orbits nothing.
    The total number of direct and indirect orbits in this example is 42.

    What is the total number of direct and indirect orbits in your map data?

    Your puzzle answer was 117672.

    --- Part Two ---
    Now, you just need to figure out how many orbital transfers you (YOU) need to take to get to Santa (SAN).

    You start at the object YOU are orbiting; your destination is the object SAN is orbiting. 
    An orbital transfer lets you move from any object to an object orbiting or orbited by that object.

    For example, suppose you have the following map:

    COM)B
    B)C
    C)D
    D)E
    E)F
    B)G
    G)H
    D)I
    E)J
    J)K
    K)L
    K)YOU
    I)SAN
    Visually, the above map of orbits looks like this:

                              YOU
                             /
            G - H       J - K - L
           /           /
    COM - B - C - D - E - F
                   \
                    I - SAN
    In this example, YOU are in orbit around K, and SAN is in orbit around I. To move from K to I, a minimum of 4 orbital transfers are required:

    K to J
    J to E
    E to D
    D to I
    Afterward, the map of orbits looks like this:

            G - H       J - K - L
           /           /
    COM - B - C - D - E - F
                   \
                    I - SAN
                     \
                      YOU
    What is the minimum number of orbital transfers required to move from the object YOU are orbiting to the object SAN is orbiting? 
    (Between the objects they are orbiting - not between YOU and SAN.)

    Your puzzle answer was 277.
    */

    public class Day6 : Day
    {
        public override string Title => "--- Day 6: Universal Orbit Map ---";

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day6.ToStringList();
            var orbitedObjects = new HashSet<OrbitedObject>(OrbitedObject.OrbitedObjectComparer);

            AddObjects(input, orbitedObjects);
            AddOrbits(input, orbitedObjects);

            var sum = orbitedObjects.Sum(s => s.TotalOrbits);
            Console.WriteLine(sum);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var input = Inputs.Day6.ToStringList();
            var orbitedObjects = new HashSet<OrbitedObject>(OrbitedObject.OrbitedObjectComparer);

            AddObjects(input, orbitedObjects);
            AddOrbits(input, orbitedObjects);

            var current = orbitedObjects.First(f => f.Id == "YOU");
            var count = -1;
            while (!current.OuterTo("SAN"))
            {
                count++;
                current = current.Orbits;
            }

            var result = count + current.DistanceTo("SAN");
            Console.WriteLine(result);
        }

        private static void AddOrbits(List<string> input, HashSet<OrbitedObject> orbitedObjects)
        {
            foreach (var entry in input)
            {
                var split = entry.Split(')');
                var inner = orbitedObjects.First(f => f.Id == split[0]);
                var outer = orbitedObjects.First(f => f.Id == split[1]);

                inner.AddOrbitedBy(outer);
                outer.AddOrbits(inner);
            }
        }

        private static void AddObjects(List<string> input, HashSet<OrbitedObject> orbitedObjects)
        {
            foreach (var entry in input)
            {
                var split = entry.Split(')');
                orbitedObjects.Add(new OrbitedObject(split[0]));
                orbitedObjects.Add(new OrbitedObject(split[1]));
            }
        }
    }

    public class OrbitedObject
    {
        private sealed class OrbitedObjectEqualityComparer : IEqualityComparer<OrbitedObject>
        {
            public bool Equals(OrbitedObject x, OrbitedObject y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.Id == y.Id;
            }

            public int GetHashCode(OrbitedObject obj)
            {
                return obj.Id.GetHashCode();
            }
        }

        public static IEqualityComparer<OrbitedObject> OrbitedObjectComparer { get; } =
            new OrbitedObjectEqualityComparer();

        public readonly string Id;
        public readonly List<OrbitedObject> OrbitedBy = new List<OrbitedObject>();
        public OrbitedObject Orbits { get; private set; }

        public int TotalOrbits
        {
            get { return OrbitedBy.Count + OrbitedBy.Sum(x => x.TotalOrbits); }
        }

        public OrbitedObject(string id)
        {
            Id = id;
        }

        public void AddOrbitedBy(OrbitedObject orbitedObject)
        {
            if (OrbitedBy.All(x => x.Id != orbitedObject.Id))
            {
                OrbitedBy.Add(orbitedObject);
            }
        }

        public void AddOrbits(OrbitedObject orbitedObject)
        {
            Orbits = orbitedObject;
        }

        public bool OuterTo(string id)
        {
            return Id == id || OrbitedBy.Any(a => a.Id == id) || OrbitedBy.Any(a => a.OuterTo(id));
        }

        public int DistanceTo(string id)
        {
            var current = OrbitedBy.FirstOrDefault(f => f.OuterTo(id));
            var count = 0;

            while (current.Id != id)
            {
                count++;
                current = current.OrbitedBy.FirstOrDefault(f => f.OuterTo(id));
            }

            return count;
        }
    }
}