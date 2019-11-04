using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace CodingProblems
{
    public static class DivideLeetCodeProblem
    {
        public static int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }

            if (divisor == 1)
            {
                return dividend;
            }

            if (divisor == -1)
            {
                var result = dividend - dividend - dividend;
                if (dividend > 0 && result > 0)
                {
                    return int.MinValue;
                }
                if (dividend < 0 && result < 0)
                {
                    return int.MaxValue;
                }
                return result;
            }

            if (dividend == divisor)
            {
                return 1;
            }

            if (dividend == 0)
            {
                return 0;
            }

            var count = 0;
            var start = dividend;
            if (dividend > 0 && divisor > 0)
            {
                while (start >= 0)
                {
                    start -= divisor;
                    if (start < 0)
                    {
                        return count;
                    }
                    count++;
                    if (count < 0)
                    {
                        return int.MaxValue;
                    }
                }
            }
            else
            {
                if (dividend > 0)
                {
                    while (start >= 0)
                    {
                        start += divisor;
                        if (start < 0)
                        {
                            return count;
                        }
                        count--;
                        if (count > 0)
                        {
                            return int.MinValue;
                        }
                    }
                }
                else
                {
                    if (divisor > 0)
                    {
                        while (start <= 0)
                        {
                            start += divisor;
                            if (start > 0)
                            {
                                return count;
                            }
                            count--;
                            if (count > 0)
                            {
                                return int.MinValue;
                            }
                        }
                    }
                    else
                    {
                        while (start <= 0)
                        {
                            start -= divisor;
                            if (start > 0)
                            {
                                return count;
                            }
                            count++;
                            if (count < 0)
                            {
                                return int.MaxValue;
                            }
                        }
                    }
                }
            }
            return count;
        }
    }
}