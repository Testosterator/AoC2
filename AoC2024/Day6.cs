using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;

namespace AoC2024
{
    public class Day6
    {
        private int _width;
        private int _height;
        private char[,] _map;
        private Point _startingPoint;

        public static void Patrol()
        {
            Day6 day6 = new Day6();

            List<string> lines = new();
            var path = @"D:\VS Projekty\AoC2024\AoC2024\inputd6.txt";

            foreach (var line in File.ReadLines(path))
            {
                day6._width = line.Length;
                day6._height++;
                lines.Add(line);
            }

            day6._map = new char[day6._width, day6._height];
            for (int y = 0; y < day6._height; y++)
            {
                for (int x = 0; x < day6._width; x++)
                {
                    day6._map[x, y] = lines[y][x];
                    if (day6._map[x, y] == '^')
                    {
                        day6._startingPoint = new Point(x, y);
                    }
                }
            }

            Console.WriteLine(day6.CountSteps(day6._startingPoint).ToString());
        }

        private int CountSteps(Point start)
        {
            HashSet<Point> visited = new();
            var currentDirection = new Point(0, -1);
            var currentPoint = start;

            while (true)
            {
                visited.Add(currentPoint);
                var nextPosition = new Point(currentPoint.X + currentDirection.X, currentPoint.Y + currentDirection.Y);

                if (IsOutOfBounds(nextPosition))
                {
                    break;
                }

                if (_map[nextPosition.X, nextPosition.Y] == '#')
                {
                    // Skręć w prawo
                    currentDirection = new Point(-currentDirection.Y, currentDirection.X);
                    nextPosition = new Point(currentPoint.X + currentDirection.X, currentPoint.Y + currentDirection.Y);
                }

                if (IsOutOfBounds(nextPosition))
                {
                    break;
                }

                currentPoint = nextPosition;
            }

            return visited.Count;
        }

        private bool IsOutOfBounds(Point position)
        {
            return position.X < 0 || position.Y < 0 || position.X >= _width || position.Y >= _height;
        }
    }
}
