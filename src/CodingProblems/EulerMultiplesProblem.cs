﻿namespace CodingProblems
{
    public class EulerMultiplesProblem
    {
        public int SumOnlyMultiplesBelow(int limit)
        {
            var sum = 0;

            for (var i = 0; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}