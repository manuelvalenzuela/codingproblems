using System;

namespace CodingProblems
{
    public class QuickSort
    {
        private long runningTotalOfComparisons = 0;
        public int[] Sort(int[] arr)
        {
            if (arr.Length == 0) return new int[] { };

            if (arr.Length == 1) return arr;

            var left = 0;
            var right = arr.Length - 1;

            Sort(arr, left, right);

            Console.WriteLine($"runningTotalOfComparisons: {runningTotalOfComparisons}");
            return arr;
        }

        private void Sort(int[] arr, int left, int right)
        {
            if (right == left) return;
            var elementsInSubArray = right - left;
            runningTotalOfComparisons += elementsInSubArray;
            //Console.WriteLine($"elementsInSubArray: {elementsInSubArray}");

            var pivotIndex = PartitionSelectingMedianElemetAsPivot(arr, left, right);
            if (pivotIndex > left)
            {
                Sort(arr, left, pivotIndex - 1);
            }

            if (pivotIndex < right)
            {
                Sort(arr, pivotIndex + 1, right);
            }
        }

        private int PartitionSelectingFirstElemetAsPivot(int[] arr, int left, int right)
        {
            //First Try: Select the first: 162085
            var pivot = arr[left];
            var i = left + 1;

            for (var j = left + 1; j <= right; j++)
            {
                if (arr[j] < pivot)
                {
                    Swap(arr, j, i);
                    i++;
                }
            }

            Swap(arr, left, i - 1);
            return i - 1;
        }

        private int PartitionSelectingLastElemetAsPivot(int[] arr, int left, int right)
        {
            //First Try: Select the last: 164123
            Swap(arr, left, right);
            var pivot = arr[left];
            var i = left + 1;

            for (var j = left + 1; j <= right; j++)
            {
                if (arr[j] < pivot)
                {
                    Swap(arr, j, i);
                    i++;
                }
            }

            Swap(arr, left, i - 1);
            return i - 1;
        }

        private int PartitionSelectingMedianElemetAsPivot(int[] arr, int left, int right)
        {
            //First Try: Select the median: 138382

            if (right - left > 1)
            {
                var mid = (right + left) / 2;
                
                var indexPivotCandidate = -1;

                if(arr[left] > arr[mid])
                {
                    if (arr[left] < arr[right])
                    {
                        indexPivotCandidate = left;
                    }
                    else
                    {
                        indexPivotCandidate = arr[mid] > arr[right] ? mid : right;
                    }
                }
                else
                {
                    if (arr[left] > arr[right])
                    {
                        indexPivotCandidate = left;
                    }
                    else
                    {
                        indexPivotCandidate = arr[mid] > arr[right] ? right : mid;
                    }
                }


                Swap(arr, left, indexPivotCandidate);
            }

            var pivot = arr[left];

            var i = left + 1;

            for (var j = left + 1; j <= right; j++)
            {
                if (arr[j] < pivot)
                {
                    Swap(arr, j, i);
                    i++;
                }
            }

            Swap(arr, left, i - 1);
            return i - 1;
        }

        private void Swap(int[] arr, int first, int second)
        {
            var tmp = arr[second];
            arr[second] = arr[first];
            arr[first] = tmp;
        }
    }
}