using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AoC_Common.SantaHelper;

namespace AoC_2018
{
    /* 
    */

    public class Day13 : Day
    {
        public override string Title => "2018 - Day 13";

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

            var ticks = 0;
            Cart crashed = null;
            var breakOut = false;
            while (breakOut == false)
            {
                Carts = Carts.Where(w => w.HasCrashed == false).OrderBy(c => c.Track.Y).ThenBy(c2 => c2.Track.X).ToList();

                if (Carts.Count == 1)
                {                    
                    Console.WriteLine(Carts[0].Track.X + "," + Carts[0].Track.Y);
                    ticks++;
                    break;
                }

                foreach (var cart in Carts)
                {
                    cart.Move();
                    //Console.WriteLine("cart " + cart.Id + ", " + cart.Track.Symbol + " at x=" + cart.Track.X + ", y=" + cart.Track.Y);

                    //if (cart.HasCrashed)
                    //{
                    //    crashed = cart;
                    //    breakOut = true;
                    //    break;
                    //}
                }

                ticks++;
            }
            // åk top -> bottom, left -> right

            //Console.WriteLine(crashed.Track.X + "," + crashed.Track.Y);
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

        public override void PartTwo()
        {
            base.PartTwo();
            Console.WriteLine();
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
            // hitta nästa baserat på håll
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