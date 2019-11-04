namespace CodingProblems
{
    using System;
    public class InversionsCounter
    {
        public long CountSplitInversions(int[] arr)
        {
            var result = MergeSort(arr);

            return result.InversionCount;
        }

        private ArrayAndCount MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return new ArrayAndCount() { array = arr, InversionCount = 0 };
            }

            var firstArrLength = arr.Length / 2;
            var secondArrSize = arr.Length - firstArrLength;

            var firstArr = new int[firstArrLength];
            var secondArr = new int[arr.Length - firstArrLength];

            Array.Copy(arr, 0, firstArr, 0, firstArrLength);
            Array.Copy(arr, firstArrLength, secondArr, 0, secondArrSize);

            var first = MergeSort(firstArr);
            var second = MergeSort(secondArr);

            var total = MergeAndCountSplitInversions(
                    first.array,
                    second.array);

            total.InversionCount += (first.InversionCount + second.InversionCount);
            
            return total;
        }

        private ArrayAndCount MergeAndCountSplitInversions(int[] b, int[] c)
        {
            var result = new ArrayAndCount()
            {
                InversionCount = 0,
                array = new int[b.Length + c.Length]
            };

            var bIndex = 0;
            var cIndex = 0;

            for (var i = 0; i < result.array.Length; i++)
            {
                if (bIndex > b.Length - 1)
                {
                    result.array[i] = c[cIndex];
                    cIndex++;
                    continue;
                }

                if (cIndex > c.Length - 1)
                {
                    result.array[i] = b[bIndex];
                    bIndex++;
                    continue;
                }

                if (b[bIndex] < c[cIndex])
                {
                    result.array[i] = b[bIndex];
                    bIndex++;
                }
                else
                {
                    result.array[i] = c[cIndex];
                    cIndex++;
                    result.InversionCount += b.Length - bIndex;
                }
            }
            return result;
        }
    }

    public class ArrayAndCount
    {
        public int[] array;
        public long InversionCount;
    }
}