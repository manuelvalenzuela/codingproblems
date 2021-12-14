namespace CodingProblems
{
    public class RemovingIslandsProblem
    {
        const int LAND = 1;
        const int SEA = 0;
        const int NEVER_VISITED = -1;
        const int WAITING = -2;

        public int[][] RemoveIslands(int[][] matrix)
        {
            if (matrix == null)
            {
                return null;
            }

            int height = matrix.Length;
            int width = matrix[0].Length;

            int[][] visited = new int[height][];
            for (int row = 0; row < height; row++)
            {
                visited[row] = new int[width];
                for (int col = 0; col < width; col++)
                {
                    visited[row][col] = NEVER_VISITED;
                }
            }

            for (int row = 1; row < height - 1; row++)
            {
                for (int col = 1; col < width - 1; col++)
                {
                    if (matrix[row][col] == 1)
                    {
                        if (!IsConnectedToEdge(matrix, row, col, visited))
                        {
                            matrix[row][col] = SEA;
                        }
                    }
                }
            }
            return matrix;
        }

        private bool IsConnectedToEdge(int[][] matrix, int row, int col, int[][] visited)
        {
            if (row < 0 || row >= matrix.Length ||
                col < 0 || col >= matrix[0].Length)
            {
                return true;
            }

            if (visited[row][col] == WAITING)
            {
                return false;
            }

            if (visited[row][col] == SEA)
            {
                return false;
            }

            if (visited[row][col] == LAND)
            {
                return true;
            }

            if (matrix[row][col] == SEA)
            {
                visited[row][col] = SEA;
                return false;
            }

            visited[row][col] = WAITING;

            bool isConnectedToEdge =
                IsConnectedToEdge(matrix, row + 1, col, visited) ||
                IsConnectedToEdge(matrix, row - 1, col, visited) ||
                IsConnectedToEdge(matrix, row, col + 1, visited) ||
                IsConnectedToEdge(matrix, row, col - 1, visited);

            visited[row][col] = NEVER_VISITED;

            if (isConnectedToEdge)
            {
                visited[row][col] = 1;
            }
            else
            {
                if (visited[row + 1][col] != WAITING &&
                    visited[row - 1][col] != WAITING &&
                    visited[row][col + 1] != WAITING &&
                    visited[row][col - 1] != WAITING)
                {
                    visited[row][col] = 0;
                }
            }

            return isConnectedToEdge;
        }
    }
}