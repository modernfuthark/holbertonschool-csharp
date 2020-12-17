using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>
    /// NUnit Tests for the Operations class
    /// </summary>
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_TwoInts(
            [Values(1, 2, 3, 4, 5, -6, -5000, 5300, 22222)] int a,
            [Values(0, -1, -2, 12000, 5554, 30, 75, -29)] int b)
        {
            var testAdd = Operations.Add(a, b);

            Assert.That(testAdd == (a + b));
        }

        [Test]
        public void Add_MinMax()
        {
            var testAdd = Operations.Add(int.MinValue, int.MaxValue);

            Assert.That(testAdd == -1);
        }
    }
}