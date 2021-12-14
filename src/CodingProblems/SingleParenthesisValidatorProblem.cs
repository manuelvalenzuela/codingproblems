using System.Collections.Generic;

namespace CodingProblems
{
    public class SingleParenthesisValidatorProblem
    {
        public bool IsValid(char[] input)
        {
            Stack<char> opened = new();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    opened.Push(input[i]);
                }
                else if (input[i] == ')')
                {
                    if (opened.Count == 0)
                    {
                        return false;
                    }
                    opened.Pop();
                }
            }
            return opened.Count == 0;
        }
    }
}