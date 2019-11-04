using System.Collections.Generic;

namespace CodingProblems
{
    public class TwoSumProblem
    {
        public static int[] TwoSum1(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                var lookingFor = target - nums[i];
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == lookingFor)
                    {
                        return new[] { i, j };
                    }
                }
            }
            return null;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var rests = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (rests.ContainsKey(target - nums[i]))
                {
                    return new int[] { rests[target - nums[i]], i };
                }
                rests.Add(nums[i], i);
            }

            return new int[] { 0, 0 };
        }
    }
}