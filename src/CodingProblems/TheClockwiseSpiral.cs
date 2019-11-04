namespace CodingProblems
{
    public class TheClockwiseSpiral
    {
        public static int[,] CreateSpiral(int N)
        {
            //if (N < 1) return null;

            var spiral = new int[N, N];

            var from = 0;
            var to = N - 1;
            var values = 0;
            var lastValue = 0;

            while (from < to)
            {
                var distance = to - from;
                for (var i = 0; i < distance; i++)
                {
                    lastValue = values + (1 + i);
                    spiral[from, from + i] = lastValue;
                    lastValue += distance;
                    spiral[from + i, to] = lastValue;
                    lastValue += distance;
                    spiral[to, to - i] = lastValue;
                    lastValue += distance;
                    spiral[to - i, from] = lastValue;
                }
                values = lastValue;
                from++;
                to--;
            }

            if (N % 2 == 1)
            {
                spiral[N / 2, N / 2] = N * N;
            }

            return spiral;
        }
    }
}