using System;
using System.Collections.Generic;

namespace CodingProblems
{
    public class LongestParenthesisSubstringProblem
    {
        public int LongestParenthesisSubstring(string parenthesis)
        {
            Stack<char> opened = new();
            int longest = 0;
            int doubleClosedCount = 0;

            for (int i = 0; i < parenthesis.Length; i++)
            {
                if (parenthesis[i] == '(')
                {
                    opened.Push(parenthesis[i]);
                }
                else if (parenthesis[i] == ')')
                {
                    if (opened.Count == 0)
                    {
                        doubleClosedCount = 0;
                    }
                    else
                    {
                        opened.Pop();
                        doubleClosedCount += 2;

                        longest = Math.Max(longest, doubleClosedCount);
                    }
                }
            }

            return longest;
        }
    }
}