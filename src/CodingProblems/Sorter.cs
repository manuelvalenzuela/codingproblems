using System;

namespace CodingProblems
{
    public class Sorter
    {
        public int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return arr;

            var firstArrLength = arr.Length / 2;
            var secondArrSize = arr.Length - firstArrLength;

            var firstArr = new int[firstArrLength];
            var secondArr = new int[arr.Length - firstArrLength];

            Array.Copy(arr, 0, firstArr, 0, firstArrLength);
            Array.Copy(arr, firstArrLength, secondArr, 0, secondArrSize);

            return Merge(MergeSort(firstArr), MergeSort(secondArr));
        }

        private int[] Merge(int[] a, int[] b)
        {
            var result = new int[a.Length + b.Length];

            var aIndex = 0;
            var bIndex = 0;

            for (var i = 0; i < result.Length; i++)
            {
                if (aIndex > a.Length - 1)
                {
                    result[i] = b[bIndex];
                    bIndex++;
                    continue;
                }

                if (bIndex > b.Length - 1)
                {
                    result[i] = a[aIndex];
                    aIndex++;
                    continue;
                }

                if (a[aIndex] < b[bIndex])
                {
                    result[i] = a[aIndex];
                    aIndex++;
                }
                else
                {
                    result[i] = b[bIndex];
                    bIndex++;
                }
            }
            return result;
        }
    }
}