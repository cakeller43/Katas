using System.Collections.Generic;
using NUnit.Framework;

namespace AdventOfCode1.Tests
{
    [TestFixture]
    class AdventOfCodeDay2Test
    {
        [Test]
        public void ShouldCalcOnePackage()
        {
            var expected = 58;
            Assert.AreEqual(expected,AdventOfCodeDay2.CalcOnePackage(2,3,4));
        }
        [Test]
        public void ShouldCalcSurfaceArea()
        {
            var expected = 52;
            Assert.AreEqual(expected, AdventOfCodeDay2.CalcSurfaceArea(2, 3, 4));
        }
        [Test]
        public void ShouldCalcBuffer()
        {
            var expected = 6;
            Assert.AreEqual(expected,AdventOfCodeDay2.CalcBuffer(2,4,3));
        }
        [Test]
        public void FindsTwoLowest()
        {
            var expected = new List<int> {2, 3};
            Assert.AreEqual(expected, AdventOfCodeDay2.FindTwoLowest(4, 3, 2));
        }



        [Test]
        public void Does_FindLowestPerimeter()
        {
            var expected = 10;
            Assert.AreEqual(expected,AdventOfCodeDay2.FindLowestPerimeter(3,2,4));
        }

        [Test]
        public void Does_FindVolume()
        {
            var expected = 24;
            Assert.AreEqual(expected,AdventOfCodeDay2.FindVolume(2,3,4));
        }
    }
}
