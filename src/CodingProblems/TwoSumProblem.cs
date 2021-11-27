using System.Collections.Generic;

namespace CodingProblems
{
    public class TwoSumProblem
    {
        public int[] TwoSum(int[] nums, int target)
        {

            Dictionary<int, int> alreadyPresents = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (alreadyPresents.ContainsKey(target - nums[i]))
                {
                    return new int[] { alreadyPresents[target - nums[i]], i };
                }

                if (!alreadyPresents.ContainsKey(nums[i]))
                {
                    alreadyPresents.Add(nums[i], i);
                }
            }

            return new int[] { -1, -1 };
        }
    }
}