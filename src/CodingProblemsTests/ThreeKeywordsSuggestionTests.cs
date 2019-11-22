using System;
using System.Collections.Generic;
using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class ThreeKeywordsSuggestionTests
    {
        private static List<string> GetValidKeywordsList()
        {
            return new List<string>
            {
                "mobile", "mouse", "moneypot", "monitor", "mousepad"
            };
        }

        [Fact]
        public void QueryNull_ShouldReturnEmptyList()
        {
            var result = ThreeKeywordsSuggestionProblem.ThreeKeywordSuggestions(0, GetValidKeywordsList(), null);
            result.Should().BeEmpty();
        }

        [Fact]
        public void RepositoryNull_ShouldReturnEmptyList()
        {
            var result = ThreeKeywordsSuggestionProblem.ThreeKeywordSuggestions(0, null, "mouse");
            result.Should().BeEmpty();
        }

        [Fact]
        public void OneLetterQuery_ShouldReturnEmptyList()
        {
            var result = ThreeKeywordsSuggestionProblem.ThreeKeywordSuggestions(0, GetValidKeywordsList(), "m");
            result.Should().BeEmpty();
        }

        [Fact]
        public void NonExstentQuery_ShouldReturnEmptyList()
        {
            var result = ThreeKeywordsSuggestionProblem.ThreeKeywordSuggestions(0, GetValidKeywordsList(), "abc");
            result.Should().BeEmpty();
        }

        [Fact]
        public void FirstExample_ShouldReturnEmptyList()
        {
            var result = ThreeKeywordsSuggestionProblem.ThreeKeywordSuggestions(0, GetValidKeywordsList(), "mouse");

            var expectedResult = new List<List<string>>
            {
                new List<string>{ "mobile", "moneypot", "monitor" },
                new List<string>{ "mouse", "mousepad" },
                new List<string>{ "mouse", "mousepad" },
                new List<string>{ "mouse", "mousepad" }
            };
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public void CustomExample1_ShouldReturnEmptyList()
        {
            var repository = new List<string>
            {
                "abcde", "abcdef", "abcdi", "abcdj", "abcdfa"
            };

            var result = ThreeKeywordsSuggestionProblem.ThreeKeywordSuggestions(0, repository, "abcde");

            var expectedResult = new List<List<string>>
            {
                new List<string>{ "abcde", "abcdef", "abcdfa" },
                new List<string>{ "abcde", "abcdef", "abcdfa" },
                new List<string>{ "abcde", "abcdef", "abcdfa" },
                new List<string>{ "abcde", "abcdef" }
            };
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public void CustomExample2_ShouldReturnEmptyList()
        {
            var repository = new List<string>
            {
                "av"
            };

            var result = ThreeKeywordsSuggestionProblem.ThreeKeywordSuggestions(0, repository, "av");

            var expectedResult = new List<List<string>>
            {
                new List<string>{ "av" }
            };
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}