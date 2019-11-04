using System;
using System.Collections.Generic;
using CodingProblems;
using Xunit;

namespace CodingProblemsTests
{
    public class JunctionBoxesMultiThreadTests
    {
        [Fact]
        public void OrderedJunctionBoxes_BasicCase()
        {
            var junctionBoxesSorter = new JunctionBoxesMultiThread();
            var boxList = new string[0];
            var sorted = junctionBoxesSorter.OrderedJunctionBoxes(boxList);

            var expected = new List<string>();
            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void OrderedJunctionBoxes_NullArraySouldThrows_ArgumentException()
        {
            var junctionBoxesSorter = new JunctionBoxesMultiThread();
            string[] boxList = null;

            Assert.Throws<ArgumentException>(() => junctionBoxesSorter.OrderedJunctionBoxes(boxList));
        }

        [Fact]
        public void OrderedJunctionBoxes_OneJunctionBox_ShouldReturnSame()
        {
            var junctionBoxesSorter = new JunctionBoxesMultiThread();
            var boxList = new[] { "r1 box ape bit" };
            var sorted = junctionBoxesSorter.OrderedJunctionBoxes(boxList);

            var expected = new List<string>() { "r1 box ape bit" };
            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void OrderedJunctionBoxes_TwoOldJunctionBox_ShouldReturnSorted()
        {
            var junctionBoxesSorter = new JunctionBoxesMultiThread();
            var boxList = new[] { "b4 xi me nu", "br8 eat nim did" };

            var sorted = junctionBoxesSorter.OrderedJunctionBoxes(boxList);

            var expected = new List<string>() { "br8 eat nim did", "b4 xi me nu" };
            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void OrderedJunctionBoxes_TwoNewJunctionBox_ShouldReturnAsItCome()
        {
            var junctionBoxesSorter = new JunctionBoxesMultiThread();

            var boxList = new[] { "t2 13 121 98", "f3 52 54 31" };

            var sorted = junctionBoxesSorter.OrderedJunctionBoxes(boxList);

            var expected = new List<string>() { "t2 13 121 98", "f3 52 54 31" };
            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void OrderedJunctionBoxes_OneNewAndOneOld_ShouldReturnOldFirst()
        {
            var junctionBoxesSorter = new JunctionBoxesMultiThread();

            var boxList = new[] { "b4 xi me nu", "t2 13 121 98" };

            var sorted = junctionBoxesSorter.OrderedJunctionBoxes(boxList);

            var expected = new List<string>() { "b4 xi me nu", "t2 13 121 98" };
            Assert.Equal(expected, sorted);
        }

        //[Fact]
        //public void OrderedJunctionBoxes_FirstExample()
        //{
        //    var junctionBoxesSorter = new JunctionBoxesMultiThread();

        //    var boxList = new[]
        //    {
        //        "mi2 jog mid pet",
        //        "wz3 34 54 398",
        //        "a1 alps cow bar",
        //        "x4 45 21 7"
        //    };

        //    var sorted = junctionBoxesSorter.OrderedJunctionBoxes(boxList);

        //    var expected = new List<string>()
        //    {
        //        "a1 alps cow bar",
        //        "mi2 jog mid pet",
        //        "wz3 34 54 398",
        //        "x4 45 21 7"
        //    };
        //    Assert.Equal(expected, sorted);
        //}

        //[Fact]
        //public void OrderedJunctionBoxes_SecondExample()
        //{
        //    var junctionBoxesSorter = new JunctionBoxesMultiThread();

        //    var boxList = new[]
        //    {
        //        "t2 13 121 98",
        //        "r1 box ape bit",
        //        "b4 xi me nu",
        //        "br8 eat nim did",
        //        "w1 has uni gry",
        //        "f3 52 54 31"
        //    };

        //    var sorted = junctionBoxesSorter.OrderedJunctionBoxes(boxList);

        //    var expected = new List<string>()
        //    {
        //        "r1 box ape bit",
        //        "br8 eat nim did",
        //        "w1 has uni gry",
        //        "b4 xi me nu",
        //        "t2 13 121 98",
        //        "f3 52 54 31"
        //    };
        //    Assert.Equal(expected, sorted);
        //}

        //[Fact]
        //public void OrderedJunctionBoxes_ExampleWithTies()
        //{
        //    var junctionBoxesSorter = new JunctionBoxesMultiThread();

        //    var boxList = new[]
        //    {
        //        "t2 13 121 98",
        //        "r1 box ape bit",
        //        "b4 has uni gry",
        //        "br8 eat nim did",
        //        "w1 has uni gry",
        //        "f3 52 54 31"
        //    };

        //    var sorted = junctionBoxesSorter.OrderedJunctionBoxes(boxList);

        //    var expected = new List<string>()
        //    {
        //        "r1 box ape bit",
        //        "br8 eat nim did",
        //        "b4 has uni gry",
        //        "w1 has uni gry",
        //        "t2 13 121 98",
        //        "f3 52 54 31"
        //    };
        //    Assert.Equal(expected, sorted);
        //}

        [Fact]
        public void OrderedJunctionBoxes_UnexpectedFormat_ShouldReturnFormattedFirst()
        {
            var junctionBoxesSorter = new JunctionBoxesMultiThread();
            var boxList = new[] { "dog -0", "cat⁮​⁮​ ⁮-0" };

            var sorted = junctionBoxesSorter.OrderedJunctionBoxes(boxList);

            var expected = new List<string> { "dog -0", "cat⁮​⁮​ ⁮-0" };
            Assert.Equal(expected, sorted);
        }
    }
}