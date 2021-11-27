using System.Collections.Generic;

namespace CodingProblems
{
    public class LengthOfLongestSubstringProblem
    {
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;

            Queue<char> alreadyPresent = new();

            foreach (char c in s)
            {
                while (alreadyPresent.Contains(c))
                {
                    alreadyPresent.Dequeue();
                }

                alreadyPresent.Enqueue(c);
                
                if (alreadyPresent.Count > result)
                {
                    result = alreadyPresent.Count;
                }
            }

            return result;
        }
    }
}