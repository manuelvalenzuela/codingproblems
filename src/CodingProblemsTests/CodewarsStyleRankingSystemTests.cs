using System;
using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class CodewarsStyleRankingSystemTests
    {
        private const int FirstGrade = -8;
        private const int TopGrade = 8;
        private const int NegativeOneRank = -1;
        private const int IncrementOfActivitySameRank = 3;
        private const int OneRank = 1;
        private const int MaxProgress = 100;

        [Fact]
        public void CreateUser_ShouldBeOfTypeUser()
        {
            var usr = new CodewarsStyleRankingSystem.User();
            //usr.Should().BeOfType<CodewarsStyleRankingSystem.User>();
            Assert.IsType<CodewarsStyleRankingSystem.User>(usr);
        }

        [Fact]
        public void CreateUser_ShouldHaveProgressEqualsZero()
        {
            var usr = new CodewarsStyleRankingSystem.User();
            //usr.progress.Should().Be(0);
            Assert.Equal(0, usr.Progress);
        }

        [Fact]
        public void CreateUser_ShouldHaveRankEqualsFirstGrade()
        {
            var usr = new CodewarsStyleRankingSystem.User();
            //usr.rank.Should().Be(FirstGrade);
            Assert.Equal(FirstGrade, usr.Rank);
        }

        [Theory]
        [InlineData(-9)]
        [InlineData(0)]
        [InlineData(9)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void IncrementProgressOutOfRanges_ShouldThrowArgumentException(int activityRank)
        {
            var usr = new CodewarsStyleRankingSystem.User();
            Action action = () => usr.IncProgress(activityRank);

            //action.Should().Throw<ArgumentException>();
            Assert.Throws<ArgumentException>(action);
        }

        [Fact]
        public void IncrementProgressSameRank_ShouldIncrementProgressByThree()
        {
            var usr = new CodewarsStyleRankingSystem.User();
            usr.IncProgress(FirstGrade);
            //usr.progress.Should().Be(IncrementOfActivitySameRank);
            Assert.Equal(IncrementOfActivitySameRank, usr.Progress);
        }

        [Fact]
        public void IncrementProgressMoreThanOneHundrer_ShouldIncrementRank()
        {
            var usr = new CodewarsStyleRankingSystem.User();
            usr.Progress = 99;
            usr.IncProgress(FirstGrade);
            //usr.rank.Should().Be(FirstGrade + 1);
            Assert.Equal(FirstGrade + 1, usr.Rank);
        }

        [Fact]
        public void IncrementProgressMoreThanOneHundred_ShouldStartProgressAtZeroPlusRest()
        {
            var usr = new CodewarsStyleRankingSystem.User();
            usr.Progress = 99;
            usr.IncProgress(FirstGrade);
            //usr.progress.Should().Be(2);
            Assert.Equal(2, usr.Progress);
        }

        [Fact]
        public void IncrementRankFromNegativeOne_ShouldBeOne()
        {
            var usr = new CodewarsStyleRankingSystem.User();
            usr.Progress = 0;
            usr.Rank = NegativeOneRank;
            usr.IncProgress(OneRank);
            //usr.progress.Should().Be(10);
            Assert.Equal(10, usr.Progress);
        }

        [Fact]
        public void IncrementRank_ShouldStopAtTopRank()
        {
            var usr = new CodewarsStyleRankingSystem.User();
            usr.Progress = 99;
            usr.Rank = TopGrade;
            usr.IncProgress(TopGrade);
            usr.Rank.Should().Be(TopGrade);
            Assert.Equal(TopGrade, usr.Rank);
        }

        [Fact]
        public void IncrementProgressOneLowerRank_ShouldIncrementProgressByOne()
        {
            var usr = new CodewarsStyleRankingSystem.User();
            usr.Rank = FirstGrade + 1;
            usr.IncProgress(FirstGrade);
            //usr.progress.Should().Be(1);
            Assert.Equal(1, usr.Progress);
        }

        [Fact]
        public void IncrementProgressInFourthRanks_ShouldIncrementProgressToHundredSixty()
        {
            var usr = new CodewarsStyleRankingSystem.User();
            usr.Rank = FirstGrade;
            usr.IncProgress(FirstGrade + 4);
            //usr.progress.Should().Be(60);
            //usr.rank.Should().Be(FirstGrade + 1);
            Assert.Equal(60, usr.Progress);
            Assert.Equal(FirstGrade + 1, usr.Rank);
        }

        [Fact]
        public void IncrementProgressGreaterThanActualRank_ShouldIncrementProgressByTenTimesTheGapTimesTheGap()
        {
            var usr = new CodewarsStyleRankingSystem.User();
            usr.Rank = FirstGrade;
            usr.IncProgress(FirstGrade + 2);
            //usr.progress.Should().Be(40);
            Assert.Equal(40, usr.Progress);
        }

        [Fact]
        public void ExampleFromCodewars()
        {
            var usr = new CodewarsStyleRankingSystem.User();
            usr.IncProgress(-7);
            usr.IncProgress(-5);

            //usr.rank.Should().Be(-7);
            //usr.progress.Should().Be(0);
            Assert.Equal(0, usr.Progress);
            Assert.Equal(-7, usr.Rank);
        }

        [Fact]
        public void Example1()
        {
            var usr = new CodewarsStyleRankingSystem.User();
            usr.IncProgress(-7); // +10
            usr.IncProgress(-5); // +90
            usr.IncProgress(-5); // +40
            usr.IncProgress(2); // +640

            //usr.progress.Should().Be(80);
            //usr.rank.Should().Be(-1);
            Assert.Equal(80, usr.Progress);
            Assert.Equal(-1, usr.Rank);
        }

        [Fact]
        public void Example2()
        {
            var user = new CodewarsStyleRankingSystem.User();

            user.Rank = -2;
            user.Progress = 1;
            user.IncProgress(-1);
            user.IncProgress(-1);
            //user.progress.Should().Be(21);
            Assert.Equal(21, user.Progress);
        }

        [Fact]
        public void Example3()
        {
            var user = new CodewarsStyleRankingSystem.User();

            user.Rank = 1;
            user.Progress = 0;
            user.IncProgress(-1);
            Assert.Equal(1, user.Progress);
        }

        [Fact]
        public void Example4()
        {
            var user = new CodewarsStyleRankingSystem.User();

            user.IncProgress(-8); // +3
            user.IncProgress(-7); // +10 = 13
            user.IncProgress(-6); // +40 = 53
            user.IncProgress(-5); // +90 = 143
            user.IncProgress(-4); // +90 = 133
            user.IncProgress(-3); // +90 = 103
            user.IncProgress(-2); // +90 = 113
            user.IncProgress(-1); // +90 = 103

            Assert.Equal(-3, user.Rank);
            Assert.Equal(3, user.Progress);

            user.IncProgress(1);// +90 = 93
            Assert.Equal(-3, user.Rank);
            Assert.Equal(93, user.Progress);

            user.IncProgress(-3);
            Assert.Equal(-3, user.Rank);
            Assert.Equal(96, user.Progress);

            user.IncProgress(-4);
            Assert.Equal(-3, user.Rank);
            Assert.Equal(97, user.Progress);

            user.IncProgress(-3);
            Assert.Equal(-2, user.Rank);
            Assert.Equal(0, user.Progress);

            user.IncProgress(2);
            Assert.Equal(-2, user.Rank);
            Assert.Equal(90, user.Progress);
        }

        [Fact]
        public void Example5()
        {
            var user = new CodewarsStyleRankingSystem.User();
            user.Rank = 8;
            user.IncProgress(-8); // +3
            user.IncProgress(8);// +3600 = 3603
            Assert.Equal(8, user.Rank);
            Assert.Equal(0, user.Progress);
        }
    }
}