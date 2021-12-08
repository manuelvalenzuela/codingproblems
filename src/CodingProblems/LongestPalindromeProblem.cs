namespace CodingProblems
{
    public class LongestPalindromeProblem
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }

            int maxGlobal = -1;
            int left = 0;
            int right = 0;

            for (var i = 0; i < s.Length; i++)
            {
                int countOdd = MaxPalindromSize(i, i, s);
                int countEven = MaxPalindromSize(i, i + 1, s);

                if(countOdd > countEven)
                {
                    if (countOdd > maxGlobal)
                    {
                        maxGlobal = countOdd;
                        left = i - (countOdd / 2);
                        right = i + (countOdd / 2);
                    }
                }
                else
                {
                    if(countEven > maxGlobal)
                    {
                        maxGlobal = countEven;
                        left = i - (countEven / 2) + 1;
                        right = i + (countEven / 2);
                    }
                }
            }

            return s.Substring(left, right - left + 1);
        }

        private int MaxPalindromSize(int positionLeft, int positionRight, string s)
        {
            var left = positionLeft;
            var right = positionRight;

            while (left >= 0 && right <= s.Length - 1 && s[left] == s[right])
            {
                left--;
                right++;
            }
            
            return right - left - 1;
        }
    }
}