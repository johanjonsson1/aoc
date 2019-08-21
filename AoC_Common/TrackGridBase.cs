using System.Collections.Generic;
using System.Linq;

namespace AoC_Common
{
    public abstract class TrackGridBase
    {
        private readonly List<TrackItem> _allTracks = new List<TrackItem>();
        private TrackItem _current;
        public TrackItem Last;

        public TrackItem Current
        {
            get => _current;
            set
            {
                Last = _current;
                _current = value;
            }
        }

        public Direction CurrentDirection = Direction.None;
        
        public List<TrackItem> All => _allTracks;

        public virtual void AddTrack(TrackItem trackItem)
        {
            _allTracks.Add(trackItem);
        }

        public virtual void Build(List<string> trackMap)
        {
            var idCounter = 0;
            var y = 0;
            for (var i = 0; i < trackMap.Count; i++)
            {
                var x = 0;
                for (var j = 0; j < trackMap[i].Length; j++)
                {
                    var current = trackMap[i][j];
                    if (current == ' ')
                    {
                        x++;
                        continue;
                    }

                    var newTrack = new TrackItem
                    {
                        Id = idCounter,
                        Coordinate = new Coordinate(x, y),
                        Symbol = current,
                        TrackType = GetTrackType(current)
                    };

                    AddTrack(newTrack);
                    x++;
                    idCounter++;
                }

                y--;
            }
        }

        public abstract TrackItem MoveNext();

        protected virtual void SetNewDirection()
        {
            if (Last == null || Current == null)
            {
                return;
            }

            if (Current.Coordinate.Y > Last.Coordinate.Y)
            {
                CurrentDirection = Direction.Up;
            }
            else if (Current.Coordinate.Y < Last.Coordinate.Y)
            {
                CurrentDirection = Direction.Down;
            }
            else if (Current.Coordinate.X > Last.Coordinate.X)
            {
                CurrentDirection = Direction.Right;
            }
            else if (Current.Coordinate.X < Last.Coordinate.X)
            {
                CurrentDirection = Direction.Left;
            }
        }

        public List<TrackItem> GetAdjacent(TrackItem trackItem)
        {
            var x = trackItem.Coordinate.X;
            var y = trackItem.Coordinate.Y;

            return _allTracks.Where(a =>
                (a.Coordinate.X == x - 1 && a.Coordinate.Y == y - 1) ||
                (a.Coordinate.X == x && a.Coordinate.Y == y - 1) ||
                (a.Coordinate.X == x + 1 && a.Coordinate.Y == y - 1) ||
                (a.Coordinate.X == x + 1 && a.Coordinate.Y == y) ||
                (a.Coordinate.X == x - 1 && a.Coordinate.Y == y) ||
                (a.Coordinate.X == x - 1 && a.Coordinate.Y == y + 1) ||
                (a.Coordinate.X == x && a.Coordinate.Y == y + 1) ||
                (a.Coordinate.X == x + 1 && a.Coordinate.Y == y + 1)).ToList();
        }

        public TrackItem GetAdjacentDown(TrackItem trackItem)
        {
            var x = trackItem.Coordinate.X;
            var y = trackItem.Coordinate.Y;

            return _allTracks.FirstOrDefault(a =>
                a.Coordinate.X == x && a.Coordinate.Y == y - 1);
        }

        public TrackItem GetAdjacentUp(TrackItem trackItem)
        {
            var x = trackItem.Coordinate.X;
            var y = trackItem.Coordinate.Y;

            return _allTracks.FirstOrDefault(a =>
                a.Coordinate.X == x && a.Coordinate.Y == y + 1);
        }

        public TrackItem GetAdjacentLeft(TrackItem trackItem)
        {
            var x = trackItem.Coordinate.X;
            var y = trackItem.Coordinate.Y;

            return _allTracks.FirstOrDefault(a =>
                a.Coordinate.X == x - 1 && a.Coordinate.Y == y);
        }

        public TrackItem GetAdjacentRight(TrackItem trackItem)
        {
            var x = trackItem.Coordinate.X;
            var y = trackItem.Coordinate.Y;

            return _allTracks.FirstOrDefault(a =>
                a.Coordinate.X == x + 1 && a.Coordinate.Y == y);
        }

        public static TrackType GetTrackType(char symbol)
        {
            switch (symbol)
            {
                case '-':
                case '>':
                case '<':
                    return TrackType.Horizontal;
                case '|':
                case '^':
                case 'v':
                    return TrackType.Vertical;
                case '+':
                    return TrackType.Intersection;
                case '/':
                    return TrackType.RightFacingCurve;
                case '\\':
                    return TrackType.LeftFacingCurve;
                default:
                    return TrackType.Other;
            }
        }

        public enum TrackType
        {
            Horizontal,
            Vertical,
            Intersection,
            LeftFacingCurve,
            RightFacingCurve,
            Other
        }

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right,
            None
        }
    }

    public class TrackItem
    {
        public int Id { get; set; }
        public Coordinate Coordinate { get; set; }
        public TrackGridBase.TrackType TrackType { get; set; }
        public char Symbol { get; set; }
    }
}
