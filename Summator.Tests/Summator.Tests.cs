using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
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
            int expected = Summator.Sum(new int[] { -5, -9 });

            Assert.That(expected == -14);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            int expected = Summator.Sum(new int[] {});

            Assert.That(expected == 0);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            int expected = Summator.Sum(new int[] { 1456, 2753 });

            Assert.That(expected == 4209);
        }

        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
            int expected = Summator.Average(new int[] { 5, 7 });

            Assert.That(expected == 6);
        }


    }
}