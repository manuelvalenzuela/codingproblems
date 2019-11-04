using System;

namespace CodingProblems
{
    public class Mathematics
    {
        public long TraditionalMultiply(string x, string y)
        {
            return Convert.ToInt64(x) * Convert.ToInt64(y);
        }

        public string KaratsubaMultiply(string x, string y)
        {
            if (x.Length == 1) return (Convert.ToInt32(x) * Convert.ToInt32(y)).ToString();

            var halfSize = x.Length / 2;

            var a = x.Substring(0, halfSize);
            var b = x.Substring(halfSize, halfSize);
            var c = y.Substring(0, halfSize);
            var d = y.Substring(halfSize, halfSize);

            var ac = KaratsubaMultiply(a, c);
            var bd = KaratsubaMultiply(b, d);
            var ad = KaratsubaMultiply(a, d);
            var bc = KaratsubaMultiply(b, c);

            var acWithZeros = CompleteWithZerosAtRight(ac, x.Length);

            var adPlusbcWithZeros = CompleteWithZerosAtRight(SumBigNumbers(ad, bc), x.Length / 2);
            return SumBigNumbers(SumBigNumbers(acWithZeros,adPlusbcWithZeros), bd);
        }

        private string SumBigNumbers(string x, string y)
        {
            var xIndex = x.Length - 1;
            var yIndex = y.Length - 1;
            var result = ""; // naming convention proposed by Martin Fowler
            var carry = 0;

            while (xIndex >= 0 || yIndex >= 0)
            {
                var vx = xIndex < 0 ? 0 : Convert.ToInt32(x[xIndex].ToString());
                var vy = yIndex < 0 ? 0 : Convert.ToInt32(y[yIndex].ToString());

                var res = carry + vx + vy;
                if (res > 9)
                {
                    result = (res - 10) + result;
                    carry = 1;
                }
                else
                {
                    result = res + result;
                    carry = 0;
                }

                xIndex--;
                yIndex--;
            }

            if (carry == 1) result = "1" + result;

            return result;
        }

        private string CompleteWithZerosAtRight(string word, int length)
        {
            for (var i = 0; i < length; i++)
            {
                word += "0";
            }

            return word;
        }
    }
}