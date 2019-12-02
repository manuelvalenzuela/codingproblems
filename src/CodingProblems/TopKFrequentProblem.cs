using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems
{
    public class TopKFrequentProblem
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (dictionary.ContainsKey(num))
                {
                    dictionary[num] += 1;
                }
                else
                {
                    dictionary.Add(num, 1);
                }
            }

            var sortedSet = new SortedSet<RankedInt>(new RankedIntComparer());

            foreach (var rankedInt in dictionary)
            {
                sortedSet.Add(new RankedInt
                {
                    Value = rankedInt.Key,
                    Rank = rankedInt.Value
                });
            }

            return sortedSet.Take(k).Select(r => r.Value).ToList();
        }

        class RankedInt
        {
            public int Rank { get; set; }

            public int Value { get; set; }
        }

        class RankedIntComparer : IComparer<RankedInt>
        {
            public int Compare(RankedInt x, RankedInt y)
            {
                if (x.Rank == y.Rank)
                {
                    return x.Value.CompareTo(y.Value);
                }

                return y.Rank.CompareTo(x.Rank);
            }
        }
    }
}