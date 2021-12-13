namespace CodingProblems
{
    public class IntegerToRomanProblem
    {
        public string IntToRoman(int num)
        {
            int m = num / 1000;
            int c = (num - (m * 1000)) / 100;
            int x = (num - (m * 1000) - (c * 100)) / 10;
            int i = num - (m * 1000) - (c * 100) - (x * 10);

            string romanNumber = "";

            for (int im = 1; im <= m; im++)
            {
                romanNumber = $"{romanNumber}M";
            }

            romanNumber = $"{romanNumber}{FillWithRomanNumber(c, 'M', 'D', 'C')}";
            romanNumber = $"{romanNumber}{FillWithRomanNumber(x, 'C', 'L', 'X')}";
            romanNumber = $"{romanNumber}{FillWithRomanNumber(i, 'X', 'V', 'I')}";

            return romanNumber;
        }

        private string FillWithRomanNumber(int number, char tenUnits, char fiveUnits, char unit)
        {
            string romanNumber = "";

            if (number > 0)
            {
                if (number == 9)
                {
                    romanNumber = $"{romanNumber}{unit}{tenUnits}";
                }
                else if (number >= 5)
                {
                    romanNumber = $"{romanNumber}{fiveUnits}";
                    for (int i = 6; i <= number; i++)
                    {
                        romanNumber = $"{romanNumber}{unit}";
                    }
                }
                else if (number == 4)
                {
                    romanNumber = $"{romanNumber}{unit}{fiveUnits}";
                }
                else
                {
                    for (int i = 1; i <= number; i++)
                    {
                        romanNumber = $"{romanNumber}{unit}";
                    }
                }
            }

            return romanNumber;
        }
    }
}