using System;

namespace CodingProblems
{
    public class HouseRobberProblem
    {
        public int Rob(int[] nums)
        {
            int[] memo = new int[nums.Length];

            if (nums.Length == 1)
            {
                return nums[0];
            }

            if (nums.Length >= 2)
            {
                memo[0] = nums[0];
                memo[1] = Math.Max(nums[0], nums[1]);
            }

            for (int i = 2; i < nums.Length; i++)
            {
                memo[i] = Math.Max(nums[i] + memo[i - 2], memo[i - 1]);
            }

            return memo[memo.Length - 1];
        }
    }
}