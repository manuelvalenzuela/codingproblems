namespace CodingProblems
{
    public class TrappingRainWaterProblem
    {
        public int Trap(int[] height)
        {
            var highestLeft = 0;
            var highestRight = 0;
            var leftIndex = 0;
            var rightIndex = height.Length - 1;
            var totalWater = 0;

            while (leftIndex < rightIndex)
            {
                if (height[leftIndex] < height[rightIndex])
                {
                    if (height[leftIndex] < highestLeft)
                    {
                        totalWater += highestLeft - height[leftIndex];
                    }
                    else
                    {
                        highestLeft = height[leftIndex];
                    }

                    leftIndex++;
                }
                else
                {
                    if (height[rightIndex] < highestRight)
                    {
                        totalWater += highestRight - height[rightIndex];
                    }
                    else
                    {
                        highestRight = height[rightIndex];
                    }

                    rightIndex--;
                }
            }
            return totalWater;
        }
    }
}