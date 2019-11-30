﻿using System;
using System.Collections.Generic;

namespace AoC.Common
{
    public class Navigator
    {
        public Coordinate CurrentCoordinate { get; private set; }
        private Face Facing { get; set; }
        private HashSet<Coordinate> VisitedCoordinates { get; } = new HashSet<Coordinate>();

        public Navigator(Coordinate startCoordinate, Face face)
        {
            CurrentCoordinate = startCoordinate;
            VisitedCoordinates.Add(startCoordinate);
            Facing = face;
        }

        public void TurnLeft()
        {
            switch (Facing)
            {
                case Face.Up:
                    Facing = Face.Left;
                    break;
                case Face.Down:
                    Facing = Face.Right;
                    break;
                case Face.Right:
                    Facing = Face.Up;
                    break;
                case Face.Left:
                    Facing = Face.Down;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void TurnRight()
        {
            switch (Facing)
            {
                case Face.Up:
                    Facing = Face.Right;
                    break;
                case Face.Down:
                    Facing = Face.Left;
                    break;
                case Face.Right:
                    Facing = Face.Down;
                    break;
                case Face.Left:
                    Facing = Face.Up;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Move(int distance)
        {
            var oldPos = CurrentCoordinate;

            switch (Facing)
            {
                case Face.Up:
                    CurrentCoordinate = new Coordinate(CurrentCoordinate.X, CurrentCoordinate.Y - distance);
                    break;
                case Face.Down:
                    CurrentCoordinate = new Coordinate(CurrentCoordinate.X, CurrentCoordinate.Y + distance);
                    break;
                case Face.Right:
                    CurrentCoordinate = new Coordinate(CurrentCoordinate.X + distance, CurrentCoordinate.Y);
                    break;
                case Face.Left:
                    CurrentCoordinate = new Coordinate(CurrentCoordinate.X - distance, CurrentCoordinate.Y);
                    break;
                default:
                    throw new ArgumentException();
            }

            int newX = oldPos.X;
            int newY = oldPos.Y;

            // add coordinates between coordinates if distance is greater than one
            while (newX != CurrentCoordinate.X || newY != CurrentCoordinate.Y)
            {
                if (newX < CurrentCoordinate.X)
                {
                    newX++;
                }
                else if (newX > CurrentCoordinate.X)
                {
                    newX--;
                }
                else if (newY < CurrentCoordinate.Y)
                {
                    newY++;
                }
                else if (newY > CurrentCoordinate.Y)
                {
                    newY--;
                }

                var newCoordinate = new Coordinate(newX, newY);
                VisitedCoordinates.Add(newCoordinate);
            }

            VisitedCoordinates.Add(CurrentCoordinate);
        }

        public enum Face
        {
            Up,
            Down,
            Right,
            Left
        }
    }
}