using System.Collections.Generic;

namespace CodingProblems
{
    public class TopKFrequentProblem
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dictionary = new();

            foreach (var num in nums)
            {
                if (dictionary.ContainsKey(num))
                {
                    dictionary[num] -= 1;
                }
                else
                {
                    dictionary.Add(num, -1);
                }
            }

            PriorityQueue<int, int> priorityQueue = new();

            foreach (KeyValuePair<int, int> pair in dictionary)
            {
                priorityQueue.Enqueue(pair.Key, pair.Value);
            }

            List<int> result = new();
            for (int i = 0; i < k; i++)
            {
                result.Add(priorityQueue.Dequeue());
            }

            return result;
        }
    }
}