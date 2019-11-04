using CodingProblems;
using Xunit;

namespace CodingProblemsTests
{
    public class FinderTests
    {
        [Fact]
        public void MazeIsEmpty_ShouldReturnNoPath()
        {
            var a = "";

            Assert.Equal(-1, Finder.PathFinder(a));
        }

        [Fact]
        public void MazeIsNotSquare_ShouldReturnNoPath()
        {
            var a = ".W.\n" +
                       "...";
            Assert.Equal(-1, Finder.PathFinder(a));
        }

        [Fact]
        public void TestBasic()
        {
            string a = ".W.\n" +
                       ".W.\n" +
                       "...",

                b = ".W.\n" +
                    ".W.\n" +
                    "W..",

                c = "......\n" +
                    "......\n" +
                    "......\n" +
                    "......\n" +
                    "......\n" +
                    "......",

                d = "......\n" +
                    "......\n" +
                    "......\n" +
                    "......\n" +
                    ".....W\n" +
                    "....W.";

            Assert.Equal(4, Finder.PathFinder(a));
            Assert.Equal(-1, Finder.PathFinder(b));
            Assert.Equal(10, Finder.PathFinder(c));
            Assert.Equal(-1, Finder.PathFinder(d));
        }

        [Fact]
        public void MinimumDistance_ThirdExample()
        {
            string area = ".....................WWWWWWWWWWWWW" +
                          ".WWWWWWWWWWWWWWWWWWW.WWWWWWWWWWWWW" +
                          ".WWWWWWWWWWWWWWWWWWW.WWWWWWWWWWWWW" +
                          ".WWWWWWWWWWWWWWWWWWW.WWWWWWWWWWWWW" +
                          ".WWWWWWWWWWWWWWWWWWW.WWWWWWWWWWWWW" +
                          ".WWWWWWWWWWWWWWWWWWW.WWWWWWWWWWWWW" +
                          ".WWWWWWWWWWWW.WWWWWW.WWWWWWWWWWWWW" +
                          ".WWWWWWWWWWWW.WWWWWW.WWWWWWWWWWWWW" +
                          ".WWWWWWWWWWWW.WWWWWW.WWWWWWWWWWWWW" +
                          ".WWWWWWWWWWWW.WWWWWW.WWWWWWWWWWWWW" +
                          ".WWWWWWWWWWWW.WWWWWW.WWWWWWWWWWWWW" +
                          ".WWWWWWWWWWWW.WWWWWW.WWWWWWWWWWWWW" +
                          "..............WWWWWW.WWWWWWWWWWWWW" +
                          "WWWWWWWWWWWWW.WWWWWW....WWWWWWWWWW" +
                          "WWWWWWWWWWWWW.WWWWWWWWW.WWWWWWWWWW" +
                          "WWWWWWWWWWWWW.WWWWWWWWW.WWWWWWWWWW" +
                          "WWWWWWWWWWWWW.WWWWWWWWW.WWWWWWWWWW" +
                          "WWWWW...WWWWW.WWWWWWWWW.WWWWWWWWWW" +
                          "WWWWWW.WWWWWW.WWWWWWWWW.WWWWWWWWWW" +
                          "WWWWWW.WWWWWW.WWWWWWWWW.WWWWWWWWWW" +
                          "WWWWWW.WWWWWW.WWWWWWWWW.WWWWWWWWWW" +
                          "WWWWWW.WWWWWW.WWWWWWWWW.WWWWWWWWWW" +
                          "WWWWWW.WWWWWW.WWWWWWWWW.WWWWWWWWWW" +
                          "WWWWWW.WWWWWW.WWWWWWW...WWWWWWWWWW" +
                          "WWWWWW.WWWWWW.WWWWWWW.WWWWWWWWWWWW" +
                          "WWWWWW.WWWWWW.........WWWWWWWWWWWW" +
                          "WWWWWW.WWWWWW.W.WWWWW.WWWWWWWWWWWW" +
                          "WWWWWW.WWWWWW.W.WWWWW.WWWWWWWWWWWW" +
                          "WWWWWW........W.WWWWW.WWWWWWWWWWWW" +
                          "WWWWWWWWWWWWWWW.WWWWW.WWWWWWWWWWWW" +
                          "WWWWWWWWWWWWWWW.WWWWW.WWWWWWWWWWWW" +
                          "WWWWWWWWWWWWWWW.WWWWW.WWWWWWWWWWWW" +
                          "WWWWWWWWWWWWWWW.WWWWW.WWWWWWWWWWWW" +
                          "WWWWWWWWWWWWWWW...................";
        
            var min = Finder.PathFinder(area);
            Assert.Equal(66, min);
        }
    }
}