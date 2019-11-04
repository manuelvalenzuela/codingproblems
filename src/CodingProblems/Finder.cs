using System;
using System.Collections.Generic;

namespace CodingProblems
{
    public class Finder
    {
        private const int NO_PATH_FOUND = -1;

        private enum MazeSpots
        {
            Point = '.',
            Wall = 'W'
        }

        public static int PathFinder(string maze)
        {
            if (string.IsNullOrEmpty(maze))
            {
                return NO_PATH_FOUND;
            }

            maze = maze.Replace("\n", "");
            var sideLength = Math.Sqrt(maze.Length);
            if (!MazeIsASquare(sideLength))
            {
                return NO_PATH_FOUND;
            }

            if (maze.Length == 1 && maze[0] != (char)MazeSpots.Point)
            {
                return NO_PATH_FOUND;
            }

            return ShortestPath(maze, (int)sideLength);
        }

        private static int ShortestPath(string maze, int side)
        {
            var row = 0;
            var col = 0;
            var initialDistance = 0;

            var markedToVisit = new Dictionary<int, int>();
            var nextToVisit = new Queue<int>();

            var index = GetIndex(row, col, side);
            nextToVisit.Enqueue(index);
            markedToVisit.Add(index, initialDistance);

            return StartVisiting(nextToVisit, markedToVisit, side, maze);
        }

        private static int StartVisiting(Queue<int> nextToVisit, Dictionary<int, int> markedToVisit, int side, string maze)
        {
            while (nextToVisit.TryDequeue(out var index))
            {
                var row = index / side;
                var col = index % side;
                if (row == side - 1 && col == side - 1)
                {
                    return markedToVisit[index];
                }

                AddNeighbors(nextToVisit, markedToVisit, index, side, maze);
            }

            return NO_PATH_FOUND;
        }

        private static void AddNeighbors(Queue<int> nextToVisit, Dictionary<int, int> markedToVisit, int index, int side, string maze)
        {
            var row = index / side;
            var col = index % side;
            var distance = markedToVisit[index] + 1;

            TryNextToVisit(nextToVisit, markedToVisit, row + 1, col, side, maze, distance);
            TryNextToVisit(nextToVisit, markedToVisit, row - 1, col, side, maze, distance);
            TryNextToVisit(nextToVisit, markedToVisit, row, col + 1, side, maze, distance);
            TryNextToVisit(nextToVisit, markedToVisit, row, col - 1, side, maze, distance);
        }

        private static void TryNextToVisit(Queue<int> nextToVisit, Dictionary<int, int> markedToVisit, int row, int col, int side, string maze, int distance)
        {
            if (row < 0)
            {
                return;
            }

            if (row >= side)
            {
                return;
            }

            if (col < 0)
            {
                return;
            }

            if (col >= side)
            {
                return;
            }

            var index = GetIndex(row, col, side);
            if (maze[index] == (char)MazeSpots.Wall)
            {
                return;
            }

            var indexToVisit = GetIndex(row, col, side);
            if (markedToVisit.ContainsKey(indexToVisit))
            {
                return;
            }

            nextToVisit.Enqueue(indexToVisit);
            markedToVisit.Add(indexToVisit, distance);
        }

        private static int GetIndex(int row, int col, int side)
        {
            return (row * side) + col;
        }

        private static bool MazeIsASquare(double sideLength)
        {
            const double TOLERANCE = 0.000001;
            return Math.Abs(sideLength - (int) sideLength) < TOLERANCE;
        }
    }
}