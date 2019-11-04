using System.Runtime.ExceptionServices;

namespace CodingProblems
{
    using System.Collections.Generic;
    using System.Linq;

    public static class MergeThreeSortedArrays
    {
        public static int[] Merge(int[] a, int[] b, int[] c)
        {
            if (a == null && b == null && c == null)
            {
                return null;
            }

            return Merge(Merge(a, b), c);
        }

        private static int[] Merge(int[] first, int[] second)
        {
            if (IsNullOrEmpty(first) && IsNullOrEmpty(second))
            {
                return new int[] { };
            }

            if (IsNullOrEmpty(first))
            {
                return second;
            }

            if (IsNullOrEmpty(second))
            {
                return first;
            }

            var itemCount = first.Length + second.Length;
            int firstIndex = 0, secondIndex = 0;
            var temporaryMerged = new List<int>();
            var actualMin = int.MinValue;

            for (var i = 0; i < itemCount; i++)
            {
                var candidateToAdd = firstIndex < first.Length && secondIndex < second.Length
                    ? first[firstIndex] < second[secondIndex]
                        ? first[firstIndex++]
                        : second[secondIndex++]
                    : firstIndex < first.Length
                        ? first[firstIndex++]
                        : second[secondIndex++];

                actualMin = AddToListIfNotExists(candidateToAdd, actualMin, temporaryMerged);
            }

            return temporaryMerged.ToArray();
        }

        private static int SelectNextItemAndIncrement2(int[] first, int[] second, ref int firstIndex, ref int secondIndex)
        {
            return firstIndex < first.Length && secondIndex < second.Length
                ? first[firstIndex] < second[secondIndex]
                    ? first[firstIndex++]
                    : second[secondIndex++]
                : firstIndex < first.Length
                    ? first[firstIndex++]
                    : second[secondIndex++];
        }

        private static int SelectNextItemAndIncrement(int[] first, int[] second, ref int firstIndex, ref int secondIndex)
        {
            if (firstIndex < first.Length && secondIndex < second.Length)
            {
                if (first[firstIndex] < second[secondIndex])
                {
                    return first[firstIndex++];
                }

                return second[secondIndex++];
            }

            if (firstIndex < first.Length)
            {
                return first[firstIndex++];
            }

            return second[secondIndex++];
        }

        private static int AddToListIfNotExists(int candidateToAdd, int lastAdded, ICollection<int> merged)
        {
            if (candidateToAdd <= lastAdded)
            {
                return lastAdded;
            }

            lastAdded = candidateToAdd;
            merged.Add(lastAdded);
            return lastAdded;
        }

        private static bool IsNullOrEmpty(int[] arr)
        {
            return arr == null || !arr.Any();
        }
    }
}