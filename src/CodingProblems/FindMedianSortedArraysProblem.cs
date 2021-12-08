using System;
using System.Collections.Generic;

namespace CodingProblems
{
    public class FindMedianSortedArraysProblem
    {
        public double FindMedianSortedArrays_BinarySearchWIP(int[] nums1, int[] nums2)
        {
            List<int> longArray;
            List<int> shortArray;

            if (nums1.Length > nums2.Length)
            {
                longArray = new(nums1);
                shortArray = new(nums2);
            }
            else
            {
                longArray = new(nums2);
                shortArray = new(nums1);
            }

            int pivotStartIndex = 0;
            int pivotEndIndex = shortArray.Count - 1;

            int shortLeftIndex = 0;
            int longLeftIndex = 0;
            int shortRightIndex = 0;
            int longRightIndex = 0;

            // re implement this condition
            while (true)
            {
                shortLeftIndex = (pivotStartIndex + pivotEndIndex) / 2;
                longLeftIndex = ((longArray.Count + shortArray.Count) / 2) - shortLeftIndex - 1;
                shortRightIndex = shortArray.Count > shortLeftIndex + 1 ? shortLeftIndex + 1 : shortLeftIndex;
                longRightIndex = longArray.Count > longLeftIndex + 1 ? longLeftIndex + 1 : longLeftIndex;

                if (shortArray[shortLeftIndex] <= longArray[longRightIndex] &&
                    longArray[longLeftIndex] <= shortArray[shortRightIndex])
                {
                    if ((longArray.Count + shortArray.Count) % 2 == 0)
                    {
                        int left = Math.Max(shortArray[shortLeftIndex], longArray[longLeftIndex]);
                        int right = Math.Min(shortArray[shortRightIndex], longArray[longRightIndex]);
                        return (left + right) / 2.0;
                    }
                    else
                    {
                        return Math.Max(shortArray[shortLeftIndex], longArray[longLeftIndex]);
                    }
                }
                else if (shortArray[shortLeftIndex] > longArray[longRightIndex])
                {
                    pivotEndIndex = shortLeftIndex;
                }
                else if (longArray[longLeftIndex] > shortArray[shortRightIndex])
                {
                    pivotStartIndex = shortRightIndex;
                }
                else
                {
                    var algo = "";
                }
            }

            if ((longArray.Count + shortArray.Count) % 2 == 0)
            {
                int left = Math.Max(shortArray[shortLeftIndex], longArray[longLeftIndex]);
                int right = Math.Min(shortArray[shortRightIndex], longArray[longRightIndex]);
                return (left + right) / 2.0;
            }
            else
            {
                return Math.Min(shortArray[shortRightIndex], longArray[longRightIndex]);
            }
        }

        private double GetMedian(List<int> longest)
        {
            double median;
            var medianIndex = longest.Count / 2;
            if (longest.Count % 2 == 0)
            {
                median = (longest[medianIndex - 1] + longest[medianIndex]) / 2.0;
            }
            else
            {
                median = longest[medianIndex];
            }

            return median;
        }

        public double FindMedianSortedArrays_Brutforce(int[] nums1, int[] nums2)
        {
            int newLength = (nums1.Length + nums2.Length) / 2;
            newLength += 1;

            var actualMin = int.MaxValue;
            var i1 = 0;
            var i2 = 0;

            double lastProm = 0.0;

            for (var i = 1; i <= newLength; i++)
            {
                if (i1 < nums1.Length && i2 < nums2.Length)
                {
                    if (nums1[i1] < nums2[i2])
                    {
                        lastProm = (actualMin + nums1[i1]) / 2.0;
                        actualMin = nums1[i1];
                        i1++;
                    }
                    else
                    {
                        lastProm = (actualMin + nums2[i2]) / 2.0;
                        actualMin = nums2[i2];
                        i2++;
                    }
                }
                else if (i1 < nums1.Length)
                {
                    lastProm = (actualMin + nums1[i1]) / 2.0;
                    actualMin = nums1[i1];
                    i1++;
                }
                else if (i2 < nums2.Length)
                {
                    lastProm = (actualMin + nums2[i2]) / 2.0;
                    actualMin = nums2[i2];
                    i2++;
                }
                else
                {

                }
            }
            if ((nums1.Length + nums2.Length) % 2 == 0)
            {
                return lastProm;
            }
            else
            {
                return (double)actualMin;
            }
        }
    }
}