using System.Collections.Generic;

namespace CodingProblems
{
    public class MinPathSumProblem
    {
        public int MinPathSum(int[][] grid)
        {
            return BFS(grid);
        }

        private int BFS(int[][] area)
        {
            if (area == null)
            {
                return 0;
            }

            var rows = area.Length;
            var cols = area[0].Length;
            var row = 0;
            var col = 0;
            var initialDistance = area[row][col];

            var markedToVisit = new Dictionary<int, int>();
            var nextToVisit = new Queue<int>();

            var index = GetIndex(row, col, cols);
            nextToVisit.Enqueue(index);
            markedToVisit.Add(index, initialDistance);

            return StartVisiting(nextToVisit, markedToVisit, rows, cols, area);
        }

        private int StartVisiting(Queue<int> nextToVisit, Dictionary<int, int> markedToVisit, int rows, int cols, int[][] area)
        {
            var distance = 0;
            while (nextToVisit.TryDequeue(out var index))
            {
                var row = index / cols;
                var col = index % cols;
                if (row == rows - 1 && col == cols - 1)
                {
                    return markedToVisit[index];
                }

                AddNeighbors(nextToVisit, markedToVisit, index, rows, cols, area);
            }

            return distance;
        }

        private void AddNeighbors(Queue<int> nextToVisit, Dictionary<int, int> markedToVisit, int index, int rows, int cols, int[][] area)
        {
            var row = index / cols;
            var col = index % cols;
            var distance = markedToVisit[index];

            TryNextToVisit(nextToVisit, markedToVisit, row + 1, col, rows, cols, area, distance);
            TryNextToVisit(nextToVisit, markedToVisit, row, col + 1, rows, cols, area, distance);
        }

        private void TryNextToVisit(Queue<int> nextToVisit, Dictionary<int, int> markedToVisit, int row, int col, int rows, int cols, int[][] area, int distance)
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

            var possibleNextValue = distance + area[row][col];

            var indexToVisit = GetIndex(row, col, cols);
            if (markedToVisit.ContainsKey(indexToVisit))
            {
                if (possibleNextValue >= markedToVisit[indexToVisit])
                {
                    return;
                }
                else
                {
                    markedToVisit[indexToVisit] = possibleNextValue;
                }
            }
            else
            {
                markedToVisit.Add(indexToVisit, possibleNextValue);
            }

            nextToVisit.Enqueue(indexToVisit);
        }

        private int GetIndex(int row, int col, int cols)
        {
            return (row * cols) + col;
        }
    }
}