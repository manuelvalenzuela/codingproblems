namespace CodingProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JunctionBoxesProblem
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

            var list = new List<string>(boxList);
            if (boxList.Length > 1)
            {
                list.Sort(CompareJunctionBoxes);
            }

            return list;
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