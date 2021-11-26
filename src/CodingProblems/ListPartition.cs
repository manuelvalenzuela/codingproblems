using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    public class ListPartition
    {
        public void Partition(List<int> list, int k)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < k)
                {
                    Swap(list, i, 0);
                }
                else if (list[i] > k)
                {
                    Swap(list, i, list.Count - 1);
                }
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