using CodingProblems;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodingProblemsTests
{
    public class HouseRobberProblemTests
    {
        [Fact]
        public void Rob_Example1()
        {
            HouseRobberProblem problem = new ();
            problem
                .Rob(new int[] { 1, 2, 3, 1 })
                .Should()
                .Be(4);
        }

        [Fact]
        public void Rob_Example2()
        {
            HouseRobberProblem problem = new ();
            problem
                .Rob(new int[] { 2, 1, 1, 2 })
                .Should()
                .Be(4);
        }
    }
}