using System.Collections.Generic;

namespace CodingProblems
{
    public class LongestPalindromeProblem
    {
        public static string LongestPalindrome(string s)
        {
            var length = s.Length;

            if (length < 2)
            {
                return s;
            }

            var isPalindrome = new bool[length, length];

            var left = 0;
            var right = 0;

            for (var j = 1; j < length; j++)
            {
                for (var i = 0; i < j; i++)
                {
                    var isInnerWordPalindrome = isPalindrome[i + 1, j - 1] || j - i <= 2;

                    if (s[i] == s[j] && isInnerWordPalindrome)
                    {
                        isPalindrome[i, j] = true;

                        if (j - i > right - left)
                        {
                            left = i;
                            right = j;
                        }
                    }
                }
            }
            return s.Substring(left, right - left + 1);
        }

        public static string LongestPalindrome2(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return s;
            }

            if (s.Length == 1)
            {
                return s;
            }

            if (s.Length == 2)
            {
                return s[0] == s[1] ? s : s[0].ToString();
            }

            var palindromesFound = new HashSet<string>();
            if (IsPalindrome(s, palindromesFound))
            {
                return s;
            }

            var length = 2;
            var longest = s[0].ToString();

            while (length < s.Length)
            {
                for (var i = 0; i < s.Length - length + 1; i++)
                {
                    var palindromeCandidate = s.Substring(i, length);

                    if (!IsPalindrome(palindromeCandidate, palindromesFound))
                    {
                        continue;
                    }

                    palindromesFound.Add(palindromeCandidate);
                    if (longest.Length < palindromeCandidate.Length)
                    {
                        longest = palindromeCandidate;
                    }
                }

                length += 1;
            }

            return longest;
        }

        private static bool IsPalindrome(string s, HashSet<string> palindromesFound)
        {
            if (s[0] != s[s.Length - 1])
            {
                return false;
            }

            if (palindromesFound.Contains(s))
            {
                return true;
            }

            if (s.Length == 2)
            {
                var isPalindrome = s[0] == s[1];
                if (isPalindrome)
                {
                    palindromesFound.Add(s);
                }
                return isPalindrome;
            }

            if (s.Length == 1)
            {
                palindromesFound.Add(s);
                return true;
            }

            var substring = s.Substring(1, s.Length - 2);

            return IsPalindrome(substring, palindromesFound);
        }
    }
}