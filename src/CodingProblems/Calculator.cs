using System.ComponentModel.Design;
using System.Globalization;

namespace CodingProblems
{
    using System;

    public class Calculator
    {
        public string Sum(string first, string second)
        {
            if (string.IsNullOrEmpty(first)) throw new ArgumentException(nameof(first));
            if (string.IsNullOrEmpty(second)) throw new ArgumentException(nameof(second));

            var difference = first.Length - second.Length;

            var totalLength = 0;

            if (difference > 0)
            {
                totalLength = first.Length;
                second = PadLeft(second, difference, "0");
            }
            else if (difference < 0)
            {
                totalLength = second.Length;
                first = PadLeft(first, Math.Abs(difference), "0");
            }
            else
            {
                totalLength = second.Length;
            }

            var sumResult = "";
            var fi = first.Length - 1;
            var si = second.Length - 1;

            var carry = 0L;
            for (var i = totalLength - 1; i >= 0; i--)
            {
                if (!long.TryParse(first[i].ToString(), out var firstNumber))
                {
                    if (first[i] == '-')
                    {
                        firstNumber = -1;
                    }
                    else
                    {
                        throw new ArgumentException(nameof(first));
                    }
                }
                if (!long.TryParse(second[i].ToString(), out var secondNumber))
                {
                    if (second[i] == '-')
                    {
                        secondNumber = -1;
                    }
                    else
                    {
                        throw new ArgumentException(nameof(second));
                    }
                }

                var sum = firstNumber + secondNumber + carry;

                if (sum > 9)
                {
                    sum = sum - 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                sumResult = $"{sum}{sumResult}";
            }

            return sumResult;
        }

        private static string PadLeft(string numberToPad, int length, string character)
        {
            for (var i = 0; i < length; i++)
            {
                numberToPad = character + numberToPad;
            }

            return numberToPad;
        }
    }
}