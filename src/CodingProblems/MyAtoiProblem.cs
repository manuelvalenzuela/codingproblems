using System;
using System.Collections.Generic;

namespace CodingProblems
{
    public class MyAtoiProblem
    {
        public const int LookingForFirstChar = 1;
        public const int LookingForNumbers = 2;
        public const int Converting = 3;

        public static int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }

            var actualStage = LookingForFirstChar;
            var validNumberAsString = "";
            foreach (var letter in str)
            {
                if (actualStage == LookingForFirstChar)
                {
                    if (!IsValidInitialChar(letter))
                    {
                        return 0;
                    }

                    if (IsNumOrSign(letter))
                    {
                        if (letter != '+')
                        {
                            validNumberAsString += letter;
                        }
                        actualStage = LookingForNumbers;
                    }
                }
                else if (actualStage == LookingForNumbers)
                {
                    if (IsNumber(letter))
                    {
                        validNumberAsString += letter;
                    }
                    else
                    {
                        actualStage = Converting;
                        return Convert(validNumberAsString);
                    }
                }
            }

            return Convert(validNumberAsString);
        }

        private static bool IsNumber(char letter)
        {
            return int.TryParse(letter.ToString(), out _);
        }

        private static bool IsNumOrSign(char letter)
        {
            return letter == '-' || letter == '+' || IsNumber(letter);
        }

        private static bool IsValidInitialChar(char letter)
        {
            return letter == '-' || letter == '+' || letter == ' ' || IsNumber(letter);
        }

        private static int Convert(string number)
        {
            try
            {
                if (int.TryParse(number, out var n))
                {
                    return n;
                }

                if (number.Length <= 1)
                {
                    return 0;
                }

                return number[0] == '-' ? int.MinValue : int.MaxValue;
            }
            catch (ArgumentOutOfRangeException)
            {
                return number[0] == '-' ? int.MinValue : int.MaxValue;
            }
        }
    }
}