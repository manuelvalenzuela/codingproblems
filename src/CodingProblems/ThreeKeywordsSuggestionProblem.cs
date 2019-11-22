namespace CodingProblems
{
    using System.Collections.Generic;
    using System.Linq;

    public class ThreeKeywordsSuggestionProblem
    {
        private const int MinQuerySize = 2;
        private const int MaxSuggestions = 3;

        public static List<List<string>> ThreeKeywordSuggestions(int numReviews, List<string> repository, string customerQuery)
        {
            var output = new List<List<string>>();

            if (repository == null)
            {
                return output;
            }

            if (string.IsNullOrEmpty(customerQuery))
            {
                return output;
            }

            if (customerQuery.Length < MinQuerySize)
            {
                return output;
            }

            for (var i = 1; i < customerQuery.Length; i++)
            {
                var keyword = customerQuery.Substring(0, i + 1);
                var firstSuggestions = GetFirstSuggestions(MaxSuggestions, keyword, repository);
                if (firstSuggestions.Any())
                {
                    output.Add(firstSuggestions);
                }
            }

            return output;
        }

        private static List<string> GetFirstSuggestions(int maxSuggestions, string word, IEnumerable<string> repository)
        {
            var sortedList = new SortedSet<string>();
            foreach (var keyword in repository)
            {
                if (keyword.StartsWith(word))
                {
                    sortedList.Add(keyword);
                }
            }

            return sortedList.Take(maxSuggestions).ToList();
        }
    }
}