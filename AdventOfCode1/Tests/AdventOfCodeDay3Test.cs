using System.Collections.Generic;
using NUnit.Framework;


namespace AdventOfCode1.Tests
{
    [TestFixture]
    class AdventOfCodeDay3Test
    {
        [Test]
        public void ShouldAddOneCoord()
        {
            AdventOfCodeDay3 a = new AdventOfCodeDay3();
            var expected = new Coord {XCoord = 0,YCoord = 1};

            a.CurrentCoord.AddTwoCoords(a.ParseOneDirection("^"));
            Assert.AreEqual(expected.XCoord, a.CurrentCoord.XCoord);
            Assert.AreEqual(expected.YCoord, a.CurrentCoord.YCoord);
        }

        [TestCase(0, 1, "^")]
        [TestCase(0, -1, "v")]
        [TestCase(-1, 0, "<")]
        [TestCase(1, 0, ">")]
        public void ShouldGiveDirection(int expectedX, int expectedY, string input)
        {
            AdventOfCodeDay3 a = new AdventOfCodeDay3();
            Coord result = a.ParseOneDirection(input);
            Assert.AreEqual(expectedX,result.XCoord);
            Assert.AreEqual(expectedY, result.YCoord);

        }

        [Test]
        public void ShouldAddUniqueMovements()
        {
            AdventOfCodeDay3 a = new AdventOfCodeDay3();
            var direction = new Coord {XCoord = 0, YCoord = 1};
            var newTotalHouses = 2;
            Assert.AreEqual(newTotalHouses,a.MapMove(direction));
        }
        [Test]
        public void ShouldIncrementTotalPresentsOnDuplicateHouse()
        {
            AdventOfCodeDay3 a = new AdventOfCodeDay3();
            var direction = new Coord { XCoord = 0, YCoord = 1 };
            a.MapMove(direction);
            var newTotalHouses = 2;
            var oppDirection = new Coord {XCoord = 0, YCoord = -1};
            Assert.AreEqual(newTotalHouses,a.MapMove(oppDirection));
            Assert.AreEqual(2,a.GridOfHouses[a.CurrentCoord.ToString()]);
        }

        //Probably a bad test. the two above are better
        [TestCase(">",2)]
        [TestCase("^>v<", 4)]
        [TestCase("^v^v^v^v^v", 2)]
        public void ShouldAddUniqueMovementsToGrid(string input,int expectedHouses)
        {
            AdventOfCodeDay3 a = new AdventOfCodeDay3();
            var inputAsArray = input.ToCharArray();
            var houseCount = 0;
            foreach (var c in inputAsArray)
            {
                var direction = a.ParseOneDirection(c.ToString());
                houseCount = a.MapMove(direction);
            }
            Assert.AreEqual(expectedHouses,houseCount);
        }
    }
}
