namespace CodingProblems
{
    using System.Collections.Generic;

    class IsPalindromeProblem
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            var validChars = new HashSet<char>("abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray());
            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                var notKnowIfIsChar = char.ToLowerInvariant(s[left]);
                while (!validChars.Contains(notKnowIfIsChar))
                {
                    left++;
                    if (left > right)
                    {
                        return true;
                    }

                    notKnowIfIsChar = char.ToLowerInvariant(s[left]);
                }

                var leftChar = notKnowIfIsChar;

                notKnowIfIsChar = char.ToLowerInvariant(s[right]);
                while (!validChars.Contains(notKnowIfIsChar))
                {
                    right--;
                    if (right < 0)
                    {
                        return true;
                    }

                    notKnowIfIsChar = char.ToLowerInvariant(s[right]);
                }

                var rightChar = notKnowIfIsChar;

                if (leftChar != rightChar)
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}