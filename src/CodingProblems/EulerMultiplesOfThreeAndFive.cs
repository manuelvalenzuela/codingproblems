namespace CodingProblems
{
    public class EulerMultiplesOfThreeAndFive
    {
        public int[] Numbers { get; }

        public EulerMultiplesOfThreeAndFive(int[] numbers)
        {
            Numbers = numbers;
        }

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