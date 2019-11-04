namespace CodingProblems
{
    using System;
    using System.Collections.Generic;

    public enum Areas
    {
        Accessible = 1,
        WithoutRoad = 0,
        Destination = 9
    }

    public class MinimumDistanceProblem
    {
        private const int NO_PATH_FOUND = -1;

        public static int MinimumDistance(int numRows, int numColumns, int[][] area)
        {
            CheckArgumentsAreValid(numRows, numColumns, area);

            if (!HaveInitialRoad(area))
            {
                return NO_PATH_FOUND;
            }

            return BFS(area);
        }

        private static int BFS(int[][] area)
        {
            var rows = area.Length;
            var cols = area[0].Length;
            var row = 0;
            var col = 0;
            var initialDistance = 0;

            var markedToVisit = new Dictionary<int, int>();
            var nextToVisit = new Queue<int>();

            var index = GetIndex(row, col, cols);
            nextToVisit.Enqueue(index);
            markedToVisit.Add(index, initialDistance);

            return StartVisiting(nextToVisit, markedToVisit, rows, cols, area);
        }

        private static int StartVisiting(Queue<int> nextToVisit, Dictionary<int, int> markedToVisit, int rows, int cols, int[][] area)
        {
            while (nextToVisit.TryDequeue(out var index))
            {
                var row = index / cols;
                var col = index % cols;
                if (area[row][col] == (int) Areas.Destination)
                {
                    return markedToVisit[index];
                }

                AddNeighbors(nextToVisit, markedToVisit, index, rows, cols, area);
            }

            return NO_PATH_FOUND;
        }

        private static void AddNeighbors(Queue<int> nextToVisit, Dictionary<int, int> markedToVisit, int index, int rows, int cols, int[][] area)
        {
            var row = index / cols;
            var col = index % cols;
            var distance = markedToVisit[index] + 1;

            TryNextToVisit(nextToVisit, markedToVisit, row + 1, col, rows, cols, area, distance);
            TryNextToVisit(nextToVisit, markedToVisit, row - 1, col, rows, cols, area, distance);
            TryNextToVisit(nextToVisit, markedToVisit, row, col + 1, rows, cols, area, distance);
            TryNextToVisit(nextToVisit, markedToVisit, row, col - 1, rows, cols, area, distance);
        }

        private static void TryNextToVisit(Queue<int> nextToVisit, Dictionary<int, int> markedToVisit, int row, int col, int rows, int cols, int[][] area, int distance)
        {
            if (row < 0)
            {
                return;
            }

            if (row >= rows)
            {
                return;
            }

            if (col < 0)
            {
                return;
            }

            if (col >= cols)
            {
                return;
            }

            if (area[row][col] == (int) Areas.WithoutRoad)
            {
                return;
            }

            var indexToVisit = GetIndex(row, col, cols);
            if (markedToVisit.ContainsKey(indexToVisit))
            {
                return;
            }

            nextToVisit.Enqueue(indexToVisit);
            markedToVisit.Add(indexToVisit, distance);
        }

        private static int GetIndex(int row, int col, int cols)
        {
            return (row * cols) + col;
        }

        private static bool HaveInitialRoad(int[][] area)
        {
            return area[0][0] == (int)Areas.Accessible;
        }

        private static void CheckArgumentsAreValid(int numRows, int numColumns, int[][] area)
        {
            CheckIsValidOrThroughArgumentException(numRows < 0, nameof(numRows));
            CheckIsValidOrThroughArgumentException(numColumns < 0, nameof(numColumns));
            CheckIsValidOrThroughArgumentException(area == null, nameof(area));
            CheckIsValidOrThroughArgumentException(area != null && area.Length != numRows, "numRows is not equals to the rows of the area array");
            CheckIsValidOrThroughArgumentException(area != null && area.Length > 0 && area[0].Length != numColumns, "numColumns is not equals to the rows of the area array");
            CheckIsValidOrThroughArgumentException(area != null && area.Length == 0, "area is an empty array");
        }

        private static void CheckIsValidOrThroughArgumentException(bool condition, string message)
        {
            if (condition)
            {
                throw new ArgumentException(message);
            }
        }
    }
}