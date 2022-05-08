using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
    {
        // Tests with Sum

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
        public void Test_Sum_ThreePossitiveNumbers()
        {
            int expected = Summator.Sum(new int[] { 5, 15, 20 });

            Assert.That(expected == 40);
        }

        [Test]
        public void Test_Sum_ThreeNegaiveNumbers()
        {
            int expected = Summator.Sum(new int[] { -5, -15, -10 });

            Assert.That(expected == -30);
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

        // Tests with Average

        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
            int expected = Summator.Average(new int[] { 5, 7 });

            Assert.That(expected == 6);
        }

        [Test]
        public void Test_Average_TwoNegativeNumbers()
        {
            int expected = Summator.Average(new int[] { -2, -10 });

            Assert.That(expected == -6);
        }

        [Test]
        public void Test_Average_ThreePossitiveNumbers()
        {
            int expected = Summator.Average(new int[] { 5, 6, 25 });

            Assert.That(expected == 12);
        }

        [Test]
        public void Test_Average_ThreeNegativeNumbers()
        {
            int expected = Summator.Average(new int[] { -1, -5, -12 });

            Assert.That(expected == -6);
        }

    }
}