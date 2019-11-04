using System;

namespace CodingProblems
{
    public class CodewarsStyleRankingSystem
    {
        public class User
        {
            private const int FirstGrade = -8;
            private const int TopGrade = 8;
            private const int RankOne = 1;
            private const int IncrementOfActivitySameRank = 3;
            private const int IncrementOfActivityOneLowerRank = 1;
            private const int MaxProgress = 100;
            private const int NegativeOneRank = -1;

            public User()
            {
                Rank = FirstGrade;
                Progress = 0;
            }

            public int Rank { get; set; }

            public int Progress { get; set; }

            public void IncProgress(int activityRank)
            {
                CheckValidInput(activityRank);

                if (IsSameRank(activityRank))
                {
                    IncrementProgress(IncrementOfActivitySameRank);
                    return;
                }

                if (IsOneRankLower(activityRank))
                {
                    IncrementProgress(IncrementOfActivityOneLowerRank);
                    return;
                }

                if (IsGreaterRank(activityRank))
                {
                    var d = CalculateDistanceBetweenRanks(activityRank);
                    IncrementProgress(d * d * 10);
                }
            }

            private static void CheckValidInput(int activityRank)
            {
                if (activityRank == 0)
                {
                    throw new ArgumentException(nameof(activityRank));
                }

                if (activityRank < FirstGrade || activityRank > TopGrade)
                {
                    throw new ArgumentException(nameof(activityRank));
                }
            }

            private bool IsSameRank(int activityRank)
            {
                return activityRank == Rank;
            }

            private bool IsOneRankLower(int inputRank)
            {
                if (Rank == RankOne)
                {
                    return Rank == inputRank + 2;
                }

                return Rank == inputRank + 1;
            }

            private bool IsGreaterRank(int activityRank)
            {
                return activityRank > Rank;
            }

            private void IncrementProgress(int activityRank)
            {
                if (Rank >= 8)
                {
                    return;
                }

                Progress += activityRank;
                ForEveryHundredIncreasesTheRange();
            }

            private int CalculateDistanceBetweenRanks(int activityRank)
            {
                var d = activityRank - Rank;

                if (Rank < 0 && activityRank > 0 || Rank > 0 && activityRank < 0)
                {
                    d -= 1;
                }

                return d;
            }

            private void ForEveryHundredIncreasesTheRange()
            {
                while (Progress >= MaxProgress)
                {
                    Progress -= MaxProgress;
                    IncrementRank();
                }
            }

            private void IncrementRank()
            {
                Rank += IncrementIfNegativeOne() + 1;
                AdjustIfNewRankIsOverTop();
            }

            private int IncrementIfNegativeOne()
            {
                return Rank == NegativeOneRank ? 1 : 0;
            }

            private void AdjustIfNewRankIsOverTop()
            {
                if (Rank < TopGrade)
                {
                    return;
                }

                Rank = TopGrade;
                Progress = 0;
            }
        }
    }
}