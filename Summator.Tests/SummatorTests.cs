using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {

            int expected = Summator.Sum(new int[] { 5, 7 });

            Assert.That(expected == 12);
        }
        [Test]
        public void Test_Sum_OnePossitiveNumbers()
        {

            int expected = Summator.Sum(new int[] { 5 });

            Assert.That(expected == 5);
        }
        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {

            int expected = Summator.Sum(new int[] { -7 - 9 });

            Assert.That(expected == -16);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {

            int expected = Summator.Sum(new int[] { });

            Assert.That(expected == 0);
        }
    }
}


