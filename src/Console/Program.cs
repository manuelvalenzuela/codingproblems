using System.Collections.Generic;
using System.IO;
using CodingProblems;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // to execute in case Unit Tests aren't enough

            var logFile = File.ReadAllLines(@"C:\Users\manue\Desktop\words.txt");
            var logList = new List<string>(logFile);

            var word = System.Console.ReadLine();
            //var nextChar = System.Console.ReadLine();
            while (word != "0")
            {
                var suggestions = ThreeKeywordsSuggestionProblem.ThreeKeywordSuggestions(0, logList, word);
                foreach (var suggestion in suggestions)
                {
                    System.Console.WriteLine(string.Join(", ", suggestion.ToArray()));
                }
                word = System.Console.ReadLine();
            }
        }
    }
}