namespace CodingProblems
{
    using System;

    public class DoubleCola
    {
        public static string WhoIsNext(string[] names, long n)
        {
            if (n < 1)
            {
                throw new ArgumentException(nameof(n));
            }

            if (n > names.Length * (long)Math.Pow(2, 60))
            {
                throw new ArgumentException(nameof(n));
            }

            var rightBound = 0L;
            var lastDoublingSize = 0L;
            long i = 0;
            while (n > rightBound)
            {
                lastDoublingSize = names.Length * (long)Math.Pow(2, i);
                
                rightBound += lastDoublingSize;
                i++;
            }

            var lastDoublingSteps = lastDoublingSize - (rightBound - (n - 1));
            var index = (int)(names.Length * (lastDoublingSteps / (double)lastDoublingSize));

            return names[index];
        }
    }
}