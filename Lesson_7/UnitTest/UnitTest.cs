using Lesson_7;
using NUnit.Framework;

namespace UnitTests
{
    public class UnitTest
    {
        [TestCase(new int[] { 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new int[] { 2, 4, 6, -4, 3 }, 2.2)]
        [TestCase(new int[] { 0, 1, 3, 5 }, 2.25)]
        [TestCase(new int[] { -1, -3, -5 }, -3)]
        [TestCase(new int[] { 2, 6, 4, 25 }, 9.25)]
        [TestCase(new int[] { 0, 2, 32, 5 }, 9.75)]
        [TestCase(new int[] { 18, 250, -90, 24 }, 50.5)]
        [TestCase(new int[] { -90, -90, -80, -25 }, -71.25)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 1)]
        public void Task1Test(int[] a, double expectedResult)
        {
            Assert.AreEqual(expectedResult, Program.myDelegate1.Invoke(a));
        }

        [TestCase(1, 2, "-", ExpectedResult = -1)]
        [TestCase(1, 2, "+", ExpectedResult =  3)]
        [TestCase(1, 2, "asdasd", ExpectedResult = int.MinValue+1)]
        [TestCase(0, 0, "-", ExpectedResult = 0)]
        [TestCase(0, 0, "+", ExpectedResult = 0)]
        [TestCase(25, 5, "-", ExpectedResult = 20)]
        [TestCase(-90, -70, "-", ExpectedResult = -20)]
        [TestCase(-90, -70, "+", ExpectedResult = -160)]
        [TestCase(500, 120, "-", ExpectedResult = 380)]
        [TestCase(500, 120, "+", ExpectedResult = 620)]
        public int Task2Test(int x, int y,string oper)
        {
            return Program.myDelegate2.Invoke(x, y, oper);
        }
    }
}
