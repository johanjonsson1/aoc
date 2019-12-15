using System;
using System.Collections.Generic;
using System.Linq;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*
    --- Day 15: Oxygen System ---
    Out here in deep space, many things can go wrong. Fortunately, many of those things have indicator lights. 
    Unfortunately, one of those lights is lit: the oxygen system for part of the ship has failed!

    According to the readouts, the oxygen system must have failed days ago after a rupture in oxygen tank two; that section of the ship was automatically sealed once oxygen levels went dangerously low. 
    A single remotely-operated repair droid is your only option for fixing the oxygen system.

    The Elves' care package included an Intcode program (your puzzle input) that you can use to remotely control the repair droid. 
    By running that program, you can direct the repair droid to the oxygen system and fix the problem.

    The remote control program executes the following steps in a loop forever:

    Accept a movement command via an input instruction.
    Send the movement command to the repair droid.
    Wait for the repair droid to finish the movement operation.
    Report on the status of the repair droid via an output instruction.
    Only four movement commands are understood: north (1), south (2), west (3), and east (4). Any other command is invalid. 
    The movements differ in direction, but not in distance: in a long enough east-west hallway, a series of commands like 4,4,4,4,3,3,3,3 would leave the repair droid back where it started.

    The repair droid can reply with any of the following status codes:

    0: The repair droid hit a wall. Its position has not changed.
    1: The repair droid has moved one step in the requested direction.
    2: The repair droid has moved one step in the requested direction; its new position is the location of the oxygen system.
    You don't know anything about the area around the repair droid, but you can figure it out by watching the status codes.

    For example, we can draw the area using D for the droid, # for walls, . for locations the droid can traverse, and empty space for unexplored locations. Then, the initial state looks like this:

          
          
       D  
          
          
    To make the droid go north, send it 1. If it replies with 0, you know that location is a wall and that the droid didn't move:

          
       #  
       D  
          
          
    To move east, send 4; a reply of 1 means the movement was successful:

          
       #  
       .D 
          
          
    Then, perhaps attempts to move north (1), south (2), and east (4) are all met with replies of 0:

          
       ## 
       .D#
        # 
          
    Now, you know the repair droid is in a dead end. Backtrack with 3 (which you already know will get a reply of 1 because you already know that location is open):

          
       ## 
       D.#
        # 
          
    Then, perhaps west (3) gets a reply of 0, south (2) gets a reply of 1, south again (2) gets a reply of 0, and then west (3) gets a reply of 2:

          
       ## 
      #..#
      D.# 
       #  
    Now, because of the reply of 2, you know you've found the oxygen system! In this example, it was only 2 moves away from the repair droid's starting position.

    What is the fewest number of movement commands required to move the repair droid from its starting position to the location of the oxygen system?

    Your puzzle answer was 294.

    --- Part Two ---
    You quickly repair the oxygen system; oxygen gradually fills the area.

    Oxygen starts in the location containing the repaired oxygen system. 
    It takes one minute for oxygen to spread to all open locations that are adjacent to a location that already contains oxygen. 
    Diagonal locations are not adjacent.

    In the example above, suppose you've used the droid to explore the area fully and have the following map (where locations that currently contain oxygen are marked O):

     ##   
    #..## 
    #.#..#
    #.O.# 
     ###  
    Initially, the only location which contains oxygen is the location of the repaired oxygen system. 
    However, after one minute, the oxygen spreads to all open (.) locations that are adjacent to a location containing oxygen:

     ##   
    #..## 
    #.#..#
    #OOO# 
     ###  
    After a total of two minutes, the map looks like this:

     ##   
    #..## 
    #O#O.#
    #OOO# 
     ###  
    After a total of three minutes:

     ##   
    #O.## 
    #O#OO#
    #OOO# 
     ###  
    And finally, the whole region is full of oxygen after a total of four minutes:

     ##   
    #OO## 
    #O#OO#
    #OOO# 
     ###  
    So, in this example, all locations contain oxygen after 4 minutes.

    Use the repair droid to get a complete map of the area. How many minutes will it take to fill with oxygen?

    Your puzzle answer was 388.
    */

    public class Day15 : Day
    {
        public override string Title => "--- Day 15: Oxygen System ---";
        public static bool PrintEnabled = true;

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day15.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
            var droid = new Droid(input);
            droid.ExploreUntilOxygen();
            //Print(droid.Grid, droid);

            var listOfMoveables = droid.Grid.GetAll().Where(x => x.IsWall == false);
            var ones = listOfMoveables.Count(m => m.Visits == 1);
            var threes = listOfMoveables.Count(m => m.Visits == 3);
            var result = ones - threes;
            Console.WriteLine(result);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var input = Inputs.Day15.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
            var droid = new Droid(input);
            droid.ExploreFullDiscovery();
            //Print(droid.Grid, droid);

            var listOfMoveables = droid.Grid.GetAll().Where(x => x.IsWall == false).ToList();
            var minuteCounter = 0;
            while (listOfMoveables.Any(x => x.IsOxygen == false))
            {
                var qualifiedOxySpreaders =
                    listOfMoveables.Where(x => x.IsOxygen && x.CompletedOxySpread == false).ToList();

                foreach (var location in qualifiedOxySpreaders)
                {
                    var adjacent = GetAdjacent(location, listOfMoveables);
                    adjacent.ForEach(a => a.IsOxygen = true);
                    location.CompletedOxySpread = true;
                }

                minuteCounter++;
            }

            Console.WriteLine(minuteCounter);
        }

        private static List<Location> GetAdjacent(Location location, List<Location> source)
        {
            var x = location.Coordinate.X;
            var y = location.Coordinate.Y;

            return source.Where(a =>
                    //(a.Coordinate.X == x - 1 && a.Coordinate.Y == y - 1) ||
                    (a.Coordinate.X == x && a.Coordinate.Y == y - 1) ||
                    //(a.Coordinate.X == x + 1 && a.Coordinate.Y == y - 1) ||
                    (a.Coordinate.X == x + 1 && a.Coordinate.Y == y) ||
                    (a.Coordinate.X == x - 1 && a.Coordinate.Y == y) ||
                    //(a.Coordinate.X == x - 1 && a.Coordinate.Y == y + 1) ||
                    (a.Coordinate.X == x && a.Coordinate.Y == y + 1) // ||
                //(a.Coordinate.X == x + 1 && a.Coordinate.Y == y + 1))
            ).ToList();
        }

        private static void Print(Grid<Coordinate, Location> grid, Droid droid)
        {
            if (!PrintEnabled)
                return;

            var locations = grid.GetAll();
            var maxY = locations.Max(x => x.Coordinate.Y);
            var minY = locations.Min(x => x.Coordinate.Y);
            var maxX = locations.Max(x => x.Coordinate.X);
            var minX = locations.Min(x => x.Coordinate.X);

            Console.WriteLine();
            for (var i = minY; i <= maxY; i++)
            {
                for (var j = minX; j <= maxX; j++)
                {
                    if (droid.CurrentCoordinate.X == j && droid.CurrentCoordinate.Y == i)
                    {
                        Console.Write('D');
                        continue;
                    }

                    if (i == 0 && j == 0)
                    {
                        Console.Write('x');
                        continue;
                    }

                    if (grid.TryGet(new Coordinate(j, i), out var loc))
                    {
                        Console.Write(GetSymbol(loc));
                        continue;
                    }

                    Console.Write(' ');
                }

                Console.WriteLine();
            }

            char GetSymbol(Location location)
            {
                if (location.IsWall)
                {
                    return '#';
                }

                if (location.IsOxygen)
                {
                    return 'o';
                }

                if (location.Visits < 9)
                {
                    return location.Visits.ToString()[0];
                }

                return 'B';
            }
        }
    }

    public class Droid
    {
        public readonly Navigator Navigator;
        public readonly IntCodeProgram IntCodeProgram;
        public Coordinate CurrentCoordinate;
        public Coordinate LastCoordinate;
        public Grid<Coordinate, Location> Grid = new Grid<Coordinate, Location>();

        public Droid(long[] memory)
        {
            var startCoordinate = new Coordinate(0, 0);
            Navigator = new Navigator(startCoordinate, Navigator.Face.Up);
            CurrentCoordinate = startCoordinate;
            LastCoordinate = startCoordinate;
            IntCodeProgram = new IntCodeProgram(memory);
            Grid.Add(startCoordinate, new Location {Coordinate = startCoordinate});
        }

        public void ExploreUntilOxygen()
        {
            long currentOutput = 0;

            while (currentOutput != 2)
            {
                currentOutput = ExploreWithIntCode();
            }
        }

        public void ExploreFullDiscovery()
        {
            var moves = 0;
            while (moves < 3000)
            {
                moves++;
                ExploreWithIntCode();
            }
        }

        private long ExploreWithIntCode()
        {
            var recommendedNextLocation = GetPrioritizedLocation();
            IntCodeProgram.LoopUntilHalt((long) recommendedNextLocation.WhenFacing + 1);
            var locationState = IntCodeProgram.Output;

            Navigator.FaceTo(recommendedNextLocation.WhenFacing);
            var locationCoordinate = Navigator.PeekMove(1);

            if (!Grid.TryGet(locationCoordinate, out var loc))
            {
                Grid.Add(locationCoordinate, new Location
                {
                    Coordinate = locationCoordinate,
                    IsWall = locationState == 0,
                    IsOxygen = locationState == 2,
                });
            }

            if (locationState == 1 || locationState == 2)
            {
                Navigator.Move(1);
                LastCoordinate = CurrentCoordinate;
                CurrentCoordinate = Navigator.CurrentCoordinate;

                Grid.TryGet(CurrentCoordinate, out loc);
                loc.Visits++;
            }

            return locationState;
        }

        private Adjacent GetPrioritizedLocation()
        {
            var adjacents = new List<Adjacent>();
            foreach (var face in FaceLoop())
            {
                Navigator.FaceTo(face);

                var adjacent = new Adjacent();
                adjacent.Coordinate = Navigator.PeekMove(1);
                adjacent.WhenFacing = face;

                Grid.TryGet(adjacent.Coordinate, out var location);
                adjacent.Location = location;

                adjacents.Add(adjacent);
            }

            var notExplored = adjacents.FirstOrDefault(f => f.Location == null);

            if (notExplored != null)
            {
                return notExplored;
            }

            var exploredAndMoveable = adjacents.Where(a => a.Location.IsWall == false).ToList();
            var moveableNotPrevious = exploredAndMoveable.Where(e => !e.Coordinate.Equals(LastCoordinate))
                .OrderBy(o => o.Location.Visits).FirstOrDefault();

            if (moveableNotPrevious != null)
            {
                return moveableNotPrevious;
            }

            return exploredAndMoveable.First(e => e.Coordinate.Equals(LastCoordinate));
        }

        private IEnumerable<Navigator.Face> FaceLoop()
        {
            yield return Navigator.Face.Up;
            yield return Navigator.Face.Right;
            yield return Navigator.Face.Left;
            yield return Navigator.Face.Down;
        }
    }

    public class Adjacent
    {
        public Coordinate Coordinate;
        public Navigator.Face WhenFacing;
        public Location Location;
    }

    public class Location
    {
        public Coordinate Coordinate;
        public bool IsWall;
        public bool IsOxygen;
        public int Visits;
        public bool CompletedOxySpread;
    }
}