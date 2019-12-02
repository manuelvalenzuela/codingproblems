namespace CodingProblems
{
    public class NumIslandsProblem
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            var rows = grid.Length;
            var cols = grid[0].Length;
            var numIslands = 0;

            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < cols; col++)
                {
                    if (grid[row][col] == '1')
                    {
                        numIslands++;
                        DFS(grid, row, col);
                    }
                }
            }

            return numIslands;
        }

        public void DFS(char[][] grid, int row, int col)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;

            if (row < 0 || col < 0 || row >= rows || col >= cols)
            {
                return;
            }

            if (grid[row][col] == '0')
            {
                return;
            }

            grid[row][col] = '0';

            DFS(grid, row + 1, col);
            DFS(grid, row, col + 1);
            DFS(grid, row - 1, col);
            DFS(grid, row, col - 1);
        }
    }
}