using System.Collections.Generic;

namespace CodingProblems
{
    public class ListPartition
    {
        public void Partition(List<int> list, int k)
        {
            if (list.Count == 0) return;

            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                while (list[left] <= k)
                {
                    left++;

                    if (left >= right) return;
                }

                while (list[right] > k)
                {
                    right--;

                    if (right <= left) return;
                }

                Swap(list, left, right);
            }
        }

        private void Swap(List<int> list, int i, int j)
        {
            int tmp = list[j];
            list[j] = list[i];
            list[i] = tmp;
        }
    }
}