using System.Collections.Generic;

namespace CodingProblems
{
    public class GenerateParenthesesProblem
    {
        List<string> combinations;
        public IList<string> GenerateParenthesis(int n)
        {
            combinations = new List<string>();
            Backtrack("", n, n);
            return combinations;
        }

        private void Backtrack(string combination, int opened, int closed)
        {
            if (opened > closed)
            {
                return;
            }
            if (opened == 0 && closed == 0)
            {
                combinations.Add(combination);
            }
            if (opened > 0)
            {
                Backtrack($"{combination}(", opened - 1, closed);
            }
            if (closed > 0)
            {
                Backtrack($"{combination})", opened, closed - 1);
            }
        }
    }
}