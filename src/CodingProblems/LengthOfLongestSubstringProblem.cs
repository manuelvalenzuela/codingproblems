using System.Collections.Generic;

namespace CodingProblems
{
    public class LengthOfLongestSubstringProblem
    {
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;

            Queue<char> candidateSubstring = new();
            HashSet<char> fastLookup = new();

            foreach (char c in s)
            {
                while (fastLookup.Contains(c))
                {
                    char charToRemove = candidateSubstring.Dequeue();
                    fastLookup.Remove(charToRemove);
                }

                candidateSubstring.Enqueue(c);
                fastLookup.Add(c);

                if (candidateSubstring.Count > result)
                {
                    result = candidateSubstring.Count;
                }
            }

            return result;
        }
    }
}