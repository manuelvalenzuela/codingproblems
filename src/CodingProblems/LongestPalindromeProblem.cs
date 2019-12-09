namespace CodingProblems
{
    class LongestPalindrom
    {
        public int Size { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }
    }

    public class LongestPalindromeProblem
    {
        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }

            var maxGlobal = new LongestPalindrom()
            {
                Size = -1,
                Left = 0,
                Right = 0
            };

            for (var i = 0; i < s.Length; i++)
            {
                var count1 = MaxPalindromAt(i, s);
                var count2 = MaxPalindromAt(i, i + 1, s);

                var candidate = count1.Size > count2.Size ? count1 : count2;

                if (candidate.Size > maxGlobal.Size)
                {
                    maxGlobal = candidate;
                }
            }
            return s.Substring(maxGlobal.Left, maxGlobal.Size);
        }

        private static LongestPalindrom MaxPalindromAt(int positionLeft, int positionRight, string s)
        {
            var length = 0;
            var left = positionLeft;
            var right = positionRight;

            while (left >= 0 && right <= s.Length - 1 && s[left] == s[right])
            {
                length += 2;
                left--;
                right++;
            }
            return new LongestPalindrom()
            {
                Size = length,
                Left = positionLeft - (length / 2) + 1,
                Right = positionRight + (length / 2) - 1
            };
        }

        private static LongestPalindrom MaxPalindromAt(int position, string s)
        {
            var length = -1;
            var left = position;
            var right = position;

            while (left >= 0 && right <= s.Length - 1 && s[left] == s[right])
            {
                length+=2;
                left--;
                right++;
            }
            return new LongestPalindrom()
            {
                Size = length,
                Left = position - (length / 2),
                Right = position + (length / 2)
            };
        }
    }
}