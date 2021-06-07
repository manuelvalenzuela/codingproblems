using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingProblems
{
    public class MergeTwoSortedLists
    {
        public static List<int> Merge(
            List<int> first,
            List<int> second)
        {
            if (first is null || second is null)
            {
                throw new ArgumentNullException();
            }

            if (!Enumerable.Any(first))
            {
                return second;
            }

            if (!second.Any())
            {
                return first;
            }

            List<int> result = new();

            var firstIndex = 0;
            var secondIndex = 0;

            while (firstIndex < first.Count
                && secondIndex < second.Count)
            {
                if (first[firstIndex] > second[secondIndex])
                {
                    result.Add(second[secondIndex]);
                    secondIndex++;
                }
                else
                {
                    result.Add(first[firstIndex]);
                    firstIndex++;
                }
            }

            while (firstIndex < first.Count)
            {
                result.Add(first[firstIndex]);
                firstIndex++;
            }

            while (secondIndex < second.Count)
            {
                result.Add(second[secondIndex]);
                secondIndex++;
            }

            return result;
        }
    }
}