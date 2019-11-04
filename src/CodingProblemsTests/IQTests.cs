using CodingProblems;
using Xunit;

namespace CodingProblemsTests
{
    public class IQTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(3, IQ.Test2("2 4 7 8 10"));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(1, IQ.Test2("1 2 2"));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(1, IQ.Test2("1 2 2 4"));
        }
    }
}