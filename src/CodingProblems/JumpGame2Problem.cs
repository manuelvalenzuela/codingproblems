using System;

namespace CodingProblems
{
    public class JumpGame2Problem
    {
        public int Jump(int[] nums)
        {
            int jumps = 0;
            int max = 0;
            int last = 0;
            
            for (int i = 0; i < nums.Length - 1; i++)
            {
                max = Math.Max(max, nums[i] + i);
                if (i == last)
                {
                    last = max;
                    jumps++;
                }
            }

            return jumps;
        }
    }
}