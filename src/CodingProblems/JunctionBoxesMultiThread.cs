namespace CodingProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class JunctionBoxesMultiThread
    {
        private const char FIELD_DELIMITER = ' ';
        private const int INVERT_ORDER = 1;
        private const int NO_ORDER = 0;
        private const int ORIGINAL_ORDER = -1;

        public List<string> OrderedJunctionBoxes(string[] boxList)
        {
            if (boxList == null)
            {
                throw new ArgumentException(nameof(boxList));
            }

            if (boxList.Length > 1)
            {
                ParallelMergeSort(boxList, 0, boxList.Length - 1);
            }

            return new List<string>(boxList);
        }

        private async void ParallelMergeSort(string[] boxes, int start, int end)
        {
            if (start == end)
            {
                return;
            }

            if (end - start == 1)
            {
                if (CompareJunctionBoxes(boxes[start], boxes[end]) > 0)
                {
                    var tmp = boxes[start];
                    boxes[start] = boxes[end];
                    boxes[end] = tmp;
                }

                return;
            }

            var leftStart = start;
            var leftEnd = (start + end) / 2;
            var rightStart = leftEnd + 1;
            var rightEnd = end;

            var taskLeft = Task.Factory.StartNew(() => ParallelMergeSort(boxes, leftStart, leftEnd));
            var taskRight = Task.Factory.StartNew(() => ParallelMergeSort(boxes, rightStart, rightEnd));

            //var taskLeft = ParallelMergeSort(boxes, leftStart, leftEnd);
            //var taskRight = ParallelMergeSort(boxes, rightStart, rightEnd);

            await Task.WhenAll(taskLeft, taskRight);
            Merge(boxes, leftStart, leftEnd, rightStart, rightEnd);
        }

        private void Merge(string[] boxes, int leftStart, int leftEnd, int rightStart, int rightEnd)
        {
            var result = new string[rightEnd - leftStart + 1];

            var leftIndex = leftStart;
            var rightIndex = rightStart;

            for (var i = 0; i < result.Length; i++)
            {
                if (leftIndex > leftEnd)
                {
                    result[i] = boxes[rightIndex];
                    rightIndex++;
                    continue;
                }

                if (rightIndex > rightEnd)
                {
                    result[i] = boxes[leftIndex];
                    leftIndex++;
                    continue;
                }

                var sortOrder = CompareJunctionBoxes(boxes[leftIndex], boxes[rightIndex]);
                if (sortOrder > 0)
                {
                    result[i] = boxes[rightIndex];
                    rightIndex++;
                }
                else
                {
                    result[i] = boxes[leftIndex];
                    leftIndex++;
                }
            }

            for (var i = 0; i < result.Length; i++)
            {
                boxes[i + leftStart] = result[i];
            }
        }

        private static int CompareJunctionBoxes(string jb1, string jb2)
        {
            var delimiterIndex1 = -1;
            var delimiterIndex2 = -1;

            // Rule 0: Inputs must be checked
            if (InputsAreNotValids(jb1, jb2, ref delimiterIndex1, ref delimiterIndex2, out var sortOrder))
            {
                return sortOrder;
            }

            var version1 = jb1.Substring(delimiterIndex1 + 1);
            var versionTokens1 = version1.Split(' ');
            var version2 = jb2.Substring(delimiterIndex2 + 1);
            var versionTokens2 = version2.Split(' ');

            // Rule 3: The newer generation boxes should also be returned, in the original order
            if (ThereAreAnyNewVersion(versionTokens1, versionTokens2, out sortOrder))
            {
                return sortOrder;
            }

            // Rule 2: If there are any ties in the older generation, ties should be broken by the alphanumeric identifier
            if (version1.Equals(version2))
            {
                return string.CompareOrdinal(
                    jb1.Substring(0, delimiterIndex1),
                    jb2.Substring(0, delimiterIndex2));
            }

            // Rule 1: Earliest lexicographic version should come first
            return string.CompareOrdinal(version1, version2);
        }

        private static bool ThereAreAnyNewVersion(string[] versionTokens1, string[] versionTokens2, out int sortOrder)
        {
            // This rule is checking that ALL the tokens of the version must be numbers
            if (versionTokens1.Any(IsNumeric))
            {
                sortOrder = versionTokens2.Any(IsNumeric) ? NO_ORDER : INVERT_ORDER;
                return true;
            }

            if (versionTokens2.Any(IsNumeric))
            {
                sortOrder = ORIGINAL_ORDER;
                return true;
            }

            sortOrder = NO_ORDER;
            return false;
        }

        private static bool InputsAreNotValids(string jb1, string jb2, ref int delimiterIndex1, ref int delimiterIndex2, out int sortOrder)
        {
            if (!IsValidFormat(jb1, ref delimiterIndex1))
            {
                sortOrder = !IsValidFormat(jb2, ref delimiterIndex2) ? NO_ORDER : INVERT_ORDER;
                return true;
            }

            if (!IsValidFormat(jb2, ref delimiterIndex2))
            {
                sortOrder = ORIGINAL_ORDER;
                return true;
            }

            sortOrder = NO_ORDER;
            return false;
        }

        private static bool IsNumeric(string numberCandidate)
        {
            return int.TryParse(numberCandidate, out _);
        }

        private static bool IsValidFormat(string junctionBox, ref int index)
        {
            index = junctionBox.IndexOf(FIELD_DELIMITER);

            if (index <= 0 || index == junctionBox.Length - 1)
            {
                return false;
            }

            return true;
        }
    }
}