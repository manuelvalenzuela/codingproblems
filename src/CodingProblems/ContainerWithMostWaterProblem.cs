namespace CodingProblems
{
    public class ContainerWithMostWaterProblem
    {
        public int MaxArea(int[] height)
        {
            int leftWall = 0;
            int rightWall = height.Length - 1;
            int maxArea = 0;

            while (leftWall < rightWall)
            {
                int leftHeight = height[leftWall];
                int rightHeight = height[rightWall];
                int distance = rightWall - leftWall;
                int minHeight = leftHeight > rightHeight ? rightHeight : leftHeight;

                int candidateArea = minHeight * distance;

                if (candidateArea > maxArea)
                {
                    maxArea = candidateArea;
                }

                if (leftHeight > rightHeight)
                {
                    rightWall--;
                }
                else
                {
                    leftWall++;
                }
            }

            return maxArea;
        }
    }
}