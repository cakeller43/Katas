using NUnit.Framework;

namespace AdventOfCode1
{
    [TestFixture]
    class AdventOfCodeDay1Test
    {
        [Test]
        public void OneOpenBrace()
        {
            Assert.AreEqual(1,Program.ParseParens("("));
        }
        [Test]
        public void OneCloseBrace()
        {
            Assert.AreEqual(-1, Program.ParseParens(")"));
        }
        [Test]
        public void BothBraces()
        {
            Assert.AreEqual(0, Program.ParseParens("()"));
        }
        [Test]
        public void MultiOpenBrace()
        {
            Assert.AreEqual(3, Program.ParseParens("((("));
        }
        [Test]
        public void MultiCloseBrace()
        {
            Assert.AreEqual(-3, Program.ParseParens(")))"));
        }
        [Test]
        public void EqualBraces()
        {
            Assert.AreEqual(0, Program.ParseParens("((()()))"));
        }
        [Test]
        public void NetOpenBraces()
        {
            Assert.AreEqual(3, Program.ParseParens("((()))((()))()((()("));
        }
        [Test]
        public void NullParamParse()
        {
            Assert.AreEqual(0, Program.ParseParens(null));
        }

        //Check Basement
        [Test]
        public void BasementOn1()
        {
            Assert.AreEqual(1, Program.FindFirstBasement(")"));
        }
        [Test]
        public void BasementOn7()
        {
            Assert.AreEqual(7, Program.FindFirstBasement("((()))))))))"));
        }
        [Test]
        public void NoBasement()
        {
            Assert.AreEqual(-1, Program.FindFirstBasement("(((((((((((((((((((((((((((((((((((((((((((("));
        }
        [Test]
        public void NullParamBasement()
        {
            Assert.AreEqual(-1, Program.FindFirstBasement(null));
        }
    }
}
