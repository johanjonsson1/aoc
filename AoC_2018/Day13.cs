using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC_2018
{
    /*
    --- Day 13: Mine Cart Madness ---
    A crop of this size requires significant logistics to transport produce, soil, fertilizer, and so on. 
    The Elves are very busy pushing things around in carts on some kind of rudimentary system of tracks they've come up with.

    Seeing as how cart-and-track systems don't appear in recorded history for another 1000 years, the Elves seem to be making this up as they go along. 
    They haven't even figured out how to avoid collisions yet.

    You map out the tracks (your puzzle input) and see where you can help.

    Tracks consist of straight paths (| and -), curves (/ and \), and intersections (+). 
    Curves connect exactly two perpendicular pieces of track; for example, this is a closed loop:

    /----\
    |    |
    |    |
    \----/
    Intersections occur when two perpendicular paths cross. 
    At an intersection, a cart is capable of turning left, turning right, or continuing straight. 
    Here are two loops connected by two intersections:

    /-----\
    |     |
    |  /--+--\
    |  |  |  |
    \--+--/  |
       |     |
       \-----/
    Several carts are also on the tracks. Carts always face either up (^), down (v), left (<), or right (>). 
    (On your initial map, the track under each cart is a straight path matching the direction the cart is facing.)

    Each time a cart has the option to turn (by arriving at any intersection), it turns left the first time, goes straight the second time, turns right the third time, 
    and then repeats those directions starting again with left the fourth time, straight the fifth time, and so on.
    This process is independent of the particular intersection at which the cart has arrived - that is, the cart has no per-intersection memory.

    Carts all move at the same speed; they take turns moving a single step at a time. 
    They do this based on their current location: carts on the top row move first (acting from left to right), then carts on the second row move (again from left to right), then carts on the third row, and so on. 
    Once each cart has moved one step, the process repeats; each of these loops is called a tick.

    For example, suppose there are two carts on a straight track:

    |  |  |  |  |
    v  |  |  |  |
    |  v  v  |  |
    |  |  |  v  X
    |  |  ^  ^  |
    ^  ^  |  |  |
    |  |  |  |  |
    First, the top cart moves. It is facing down (v), so it moves down one square. 
    Second, the bottom cart moves. It is facing up (^), so it moves up one square. 
    Because all carts have moved, the first tick ends. Then, the process repeats, starting with the first cart. 
    The first cart moves down, then the second cart moves up - right into the first cart, colliding with it! (The location of the crash is marked with an X.) 
    This ends the second and last tick.

    Here is a longer example:

    /->-\        
    |   |  /----\
    | /-+--+-\  |
    | | |  | v  |
    \-+-/  \-+--/
      \------/   

    /-->\        
    |   |  /----\
    | /-+--+-\  |
    | | |  | |  |
    \-+-/  \->--/
      \------/   

    /---v        
    |   |  /----\
    | /-+--+-\  |
    | | |  | |  |
    \-+-/  \-+>-/
      \------/   

    /---\        
    |   v  /----\
    | /-+--+-\  |
    | | |  | |  |
    \-+-/  \-+->/
      \------/   

    /---\        
    |   |  /----\
    | /->--+-\  |
    | | |  | |  |
    \-+-/  \-+--^
      \------/   

    /---\        
    |   |  /----\
    | /-+>-+-\  |
    | | |  | |  ^
    \-+-/  \-+--/
      \------/   

    /---\        
    |   |  /----\
    | /-+->+-\  ^
    | | |  | |  |
    \-+-/  \-+--/
      \------/   

    /---\        
    |   |  /----<
    | /-+-->-\  |
    | | |  | |  |
    \-+-/  \-+--/
      \------/   

    /---\        
    |   |  /---<\
    | /-+--+>\  |
    | | |  | |  |
    \-+-/  \-+--/
      \------/   

    /---\        
    |   |  /--<-\
    | /-+--+-v  |
    | | |  | |  |
    \-+-/  \-+--/
      \------/   

    /---\        
    |   |  /-<--\
    | /-+--+-\  |
    | | |  | v  |
    \-+-/  \-+--/
      \------/   

    /---\        
    |   |  /<---\
    | /-+--+-\  |
    | | |  | |  |
    \-+-/  \-<--/
      \------/   

    /---\        
    |   |  v----\
    | /-+--+-\  |
    | | |  | |  |
    \-+-/  \<+--/
      \------/   

    /---\        
    |   |  /----\
    | /-+--v-\  |
    | | |  | |  |
    \-+-/  ^-+--/
      \------/   

    /---\        
    |   |  /----\
    | /-+--+-\  |
    | | |  X |  |
    \-+-/  \-+--/
      \------/   
    After following their respective paths for a while, the carts eventually crash. 
    To help prevent crashes, you'd like to know the location of the first crash. 
    Locations are given in X,Y coordinates, where the furthest left column is X=0 and the furthest top row is Y=0:

               111
     0123456789012
    0/---\        
    1|   |  /----\
    2| /-+--+-\  |
    3| | |  X |  |
    4\-+-/  \-+--/
    5  \------/   
    In this example, the location of the first crash is 7,3.

    --- Part Two ---
    There isn't much you can do to prevent crashes in this ridiculous system. 
    However, by predicting the crashes, the Elves know where to be in advance and instantly remove the two crashing carts the moment any crash occurs.

    They can proceed like this for a while, but eventually, they're going to run out of carts. 
    It could be useful to figure out where the last cart that hasn't crashed will end up.

    For example:

    />-<\  
    |   |  
    | /<+-\
    | | | v
    \>+</ |
      |   ^
      \<->/

    /---\  
    |   |  
    | v-+-\
    | | | |
    \-+-/ |
      |   |
      ^---^

    /---\  
    |   |  
    | /-+-\
    | v | |
    \-+-/ |
      ^   ^
      \---/

    /---\  
    |   |  
    | /-+-\
    | | | |
    \-+-/ ^
      |   |
      \---/
    After four very expensive crashes, a tick ends with only one cart remaining; its final location is 6,4.

    What is the location of the last cart at the end of the first tick where it is the only cart left?
    */

    public class Day13 : Day
    {
        public override string Title => "2018 - Day 13: Mine Cart Madness";

        public const string TrackMap = @"/->-\        
|   |  /----\
| /-+--+-\  |
| | |  | v  |
\-+-/  \-+--/
  \------/   ";

        public static List<Cart> Carts = new List<Cart>();
        public static List<Track> Tracks = new List<Track>();

        public override void PartOne()
        {
            base.PartOne();
            var trackMap = Inputs.Day13.ToStringList(); //TrackMap.ToStringList();
            BuildTracksWithCarts(trackMap);

            var breakOut = false;
            while (breakOut == false)
            {
                Carts = Carts.Where(w => w.HasCrashed == false).OrderBy(c => c.Track.Y).ThenBy(c2 => c2.Track.X).ToList();

                foreach (var cart in Carts)
                {
                    cart.Move();
                    if (cart.HasCrashed)
                    {
                        Console.WriteLine(cart.Track.X + "," + cart.Track.Y); //33,69
                        breakOut = true;
                        break;
                    }
                }
            }
        }

        public override void PartTwo()
        {
            base.PartTwo();
            Carts = new List<Cart>();
            Tracks = new List<Track>();
            var trackMap = Inputs.Day13.ToStringList();
            BuildTracksWithCarts(trackMap);

            while (true)
            {
                Carts = Carts.Where(w => w.HasCrashed == false).OrderBy(c => c.Track.Y).ThenBy(c2 => c2.Track.X).ToList();

                if (Carts.Count == 1)
                {
                    Console.WriteLine(Carts[0].Track.X + "," + Carts[0].Track.Y); // 135,9
                    break;
                }

                foreach (var cart in Carts)
                {
                    cart.Move();
                }
            }
        }

        private static void BuildTracksWithCarts(List<string> trackMap)
        {
            var idTracker = 1;
            for (int y = 0; y < trackMap.Count; y++)
            {
                for (int x = 0; x < trackMap[y].Length; x++)
                {
                    var currentSquare = trackMap[y][x];
                    if (currentSquare == ' ')
                    {
                        continue;
                    }

                    var newTrack = new Track(currentSquare, x, y, Tracks);
                    Tracks.Add(newTrack);
                    if (Cart.IsCart(currentSquare, out var cartFacing))
                    {
                        Carts.Add(new Cart(idTracker, newTrack, cartFacing));
                        idTracker++;
                    }
                }
            }
        }
    }

    public class Cart
    {
        public int Id;
        public Track Track;
        public CartFacing Facing;
        public bool HasCrashed;
        private IntersectionChoice? NextChoice = null;

        public Cart(int id, Track track, CartFacing facing)
        {
            Id = id;
            Track = track;
            Facing = facing;
        }

        public void Move()
        {
            var newPosition = Track.GetNext(Facing);
            var crashBuddy = Day13.Carts.FirstOrDefault(a => a.Track.Equals(newPosition));
            if (crashBuddy != null)
            {
                crashBuddy.HasCrashed = true;
                HasCrashed = true;
            }

            if (newPosition.Type == TrackType.LeftFacingCurve)
            {
                if (Facing == CartFacing.Up)
                {
                    Facing = CartFacing.Left;
                }
                else if (Facing == CartFacing.Right)
                {
                    Facing = CartFacing.Down;
                }
                else if (Facing == CartFacing.Down)
                {
                    Facing = CartFacing.Right;
                }
                else if (Facing == CartFacing.Left)
                {
                    Facing = CartFacing.Up;
                }
            }
            else if (newPosition.Type == TrackType.RightFacingCurve)
            {
                if (Facing == CartFacing.Up)
                {
                    Facing = CartFacing.Right;
                }
                else if (Facing == CartFacing.Right)
                {
                    Facing = CartFacing.Up;
                }
                else if (Facing == CartFacing.Down)
                {
                    Facing = CartFacing.Left;
                }
                else if (Facing == CartFacing.Left)
                {
                    Facing = CartFacing.Down;
                }
            }
            else if (newPosition.Type == TrackType.Intersection)
            {
                NextChoice = GetNext(NextChoice);

                if (Facing == CartFacing.Left && NextChoice == IntersectionChoice.Left)
                {
                    Facing = CartFacing.Down;
                }
                else if (Facing == CartFacing.Left && NextChoice == IntersectionChoice.Right)
                {
                    Facing = CartFacing.Up;
                }
                else if (Facing == CartFacing.Up && NextChoice == IntersectionChoice.Left)
                {
                    Facing = CartFacing.Left;
                }
                else if (Facing == CartFacing.Up && NextChoice == IntersectionChoice.Right)
                {
                    Facing = CartFacing.Right;
                }
                else if (Facing == CartFacing.Right && NextChoice == IntersectionChoice.Left)
                {
                    Facing = CartFacing.Up;
                }
                else if (Facing == CartFacing.Right && NextChoice == IntersectionChoice.Right)
                {
                    Facing = CartFacing.Down;
                }

                else if (Facing == CartFacing.Down && NextChoice == IntersectionChoice.Left)
                {
                    Facing = CartFacing.Right;
                }
                else if (Facing == CartFacing.Down && NextChoice == IntersectionChoice.Right)
                {
                    Facing = CartFacing.Left;
                }
            }

            Track = newPosition;
        }

        private IntersectionChoice GetNext(IntersectionChoice? current)
        {
            switch (current)
            {
                case null:
                    return IntersectionChoice.Left;
                case IntersectionChoice.Left:
                    return IntersectionChoice.Straight;
                case IntersectionChoice.Straight:
                    return IntersectionChoice.Right;
                case IntersectionChoice.Right:
                    return IntersectionChoice.Left;
                default:
                    throw new ArgumentException();
            }
        }

        public static bool IsCart(char symbol, out CartFacing cartFacing)
        {
            cartFacing = CartFacing.None;

            switch (symbol)
            {
                case '<':
                    cartFacing = CartFacing.Left;
                    return true;
                case '>':
                    cartFacing = CartFacing.Right;
                    return true;
                case '^':
                    cartFacing = CartFacing.Up;
                    return true;
                case 'v':
                    cartFacing = CartFacing.Down;
                    return true;
                default:
                    return false;
            }
        }
    }

    public class Track
    {
        public int X;
        public int Y;
        public TrackType Type;
        private readonly List<Track> _tracks;
        public char Symbol;

        public Track(char symbol, int x, int y, List<Track> tracks)
        {
            X = x;
            Y = y;
            Type = GetTrackType(symbol);
            _tracks = tracks;
        }

        public Track GetNext(CartFacing cartFacing)
        {
            switch (cartFacing)
            {
                case CartFacing.Up:
                    return _tracks.First(t => t.X == X && t.Y == Y - 1);
                case CartFacing.Down:
                    return _tracks.First(t => t.X == X && t.Y == Y + 1);
                case CartFacing.Left:
                    return _tracks.First(t => t.X == X - 1 && t.Y == Y);
                case CartFacing.Right:
                    return _tracks.First(t => t.X == X + 1 && t.Y == Y);
                case CartFacing.None:
                    throw new ArgumentException("what");                    
                default:
                    throw new ArgumentException("what");
            }
        }

        private TrackType GetTrackType(char symbol)
        {
            switch (symbol)
            {
                case '-':
                case '>':
                case '<':
                    Symbol = '-';
                    return TrackType.Horizontal;
                case '|':
                case '^':
                case 'v':
                    Symbol = '|';
                    return TrackType.Vertical;
                case '+':
                    Symbol = '+';
                    return TrackType.Intersection;
                case '/':
                    Symbol = '/';
                    return TrackType.RightFacingCurve;
                case '\\':
                    Symbol = '\\';
                    return TrackType.LeftFacingCurve;
                default:
                    throw new ArgumentException($"{symbol} not supported", paramName: nameof(symbol));
            }
        }
    }

    public enum TrackType
    {
        Horizontal,
        Vertical,
        Intersection,
        LeftFacingCurve,
        RightFacingCurve
    }

    public enum CartFacing
    {
        Up,
        Down,
        Left,
        Right,
        None
    }

    public enum IntersectionChoice
    {
        Left,
        Straight,
        Right        
    }
}