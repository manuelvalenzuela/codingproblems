using System;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices.ComTypes;

namespace CodingProblems
{
    public class IQ
    {
        public static int Test2(string numbers)
        {
            var numberStr = "";
            var evens = 0;
            var odds = 0;
            var firstEven = 0;
            var firstOdd = 0;
            var numberCount = 0;

            foreach (var number in numbers)
            {
                if (char.IsNumber(number))
                {
                    numberStr += number;
                }
                else
                {
                    if (!int.TryParse(numberStr, out var theNumber)) continue;

                    numberCount++;

                    if (theNumber % 2 == 0)
                    {
                        evens++;
                        if (firstEven == 0)
                        {
                            firstEven = numberCount;
                        }
                    }
                    else
                    {
                        odds++;
                        if (firstOdd == 0)
                        {
                            firstOdd = numberCount;
                        }
                    }

                    if (firstOdd >= 1 && firstEven >= 1 && numberCount > 2)
                    {
                        return evens > odds ? firstOdd : firstEven;
                    }

                    numberStr = "";
                }
            }

            if (!int.TryParse(numberStr, out var lastNumber)) return -1;

            numberCount++;

            if (lastNumber % 2 == 0)
            {
                evens++;
                if (firstEven == 0)
                {
                    firstEven = numberCount;
                }
            }
            else
            {
                odds++;
                if (firstOdd == 0)
                {
                    firstOdd = numberCount;
                }
            }

            if (firstOdd >= 1 && firstEven >= 1 && numberCount > 2)
            {
                return evens > odds ? firstOdd : firstEven;
            }
            return -1;
        }

        internal class EvennessDetector
        {
            public int Evens = 0;
            public int Odds = 0;
            public int FirstEven = 0;
            public int FirstOdd = 0;
            public int NumberCount = 0;

            public int InsertAndDetect(int number)
            {
                NumberCount++;

                if (number % 2 == 0)
                {
                    Evens++;
                    if (FirstEven == 0)
                    {
                        FirstEven = NumberCount;
                    }
                }
                else
                {
                    Odds++;
                    if (FirstOdd == 0)
                    {
                        FirstOdd = NumberCount;
                    }
                }

                return Detect();
            }

            private int Detect()
            {
                var detectedIndex = -1;
                if (FirstOdd >= 1 && FirstEven >= 1 && NumberCount > 2)
                {
                    detectedIndex = Evens > Odds ? FirstOdd : FirstEven;
                }

                return detectedIndex;
            }
        }

        public static int Test(string numbers)
        {
            var numberStr = "";
            var detector = new EvennessDetector();

            foreach (var number in numbers)
            {
                if (char.IsNumber(number))
                {
                    numberStr += number;
                }
                else
                {
                    if (!int.TryParse(numberStr, out var theNumber)) continue;

                    var index = detector.InsertAndDetect(theNumber);

                    if (index > 0)
                    {
                        return index;
                    }

                    numberStr = "";
                }
            }

            if (!int.TryParse(numberStr, out var lastNumber)) return -1;

            return detector.InsertAndDetect(lastNumber);
        }
    }
}