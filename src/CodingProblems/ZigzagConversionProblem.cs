using System.Collections.Generic;

namespace CodingProblems
{
    public class ZigzagConversionProblem
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1 || s.Length < numRows)
            {
                return s;
            }

            List<string> map = new();

            for (int i = 0; i < numRows; i++)
            {
                map.Add("");
            }

            Direction direction = Direction.DOWN;

            int row = 0;

            foreach (char c in s)
            {
                map[row] = $"{map[row]}{c}";

                if (direction == Direction.DOWN)
                {
                    row++;

                    if (row == numRows)
                    {
                        row = numRows - 2;
                        if (row > 0)
                        {
                            direction = Direction.RIGHT;
                        }
                        else
                        {
                            direction = Direction.DOWN;
                        }
                    }
                }
                else if (direction == Direction.RIGHT)
                {
                    row--;

                    if (row <= 0)
                    {
                        row = 0;
                        direction = Direction.DOWN;
                    }
                }
            }

            return string.Join("", map);
        }

        public enum Direction
        {
            DOWN,
            RIGHT
        }
    }
}