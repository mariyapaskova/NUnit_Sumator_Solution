using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7 });

            int expected = 12;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_OnePositiveNumber()
        {
            long actual = Summator.Sum(new int[] { 5 });

            Assert.That(actual == 5);
        }

        [Test]
        public void Test_Sum_OneNegativeNumber()
        {
            long actual = Summator.Sum(new int[] { -5 });

            Assert.That(actual == -5);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = Summator.Sum(new int[] { -7, -9 });

            Assert.That(actual == -16);
        }

        [Test]
        public void Test_Sum_OnePositiveOneNegativeNumbers()
        {
            long actual = Summator.Sum(new int[] { 7, -9 });

            Assert.That(actual == -2);
        }

        [Test]
        public void Test_Sum_OnePositiveZeroNumbers()
        {
            long actual = Summator.Sum(new int[] { 7, 0 });

            Assert.That(actual == 7);
        }

        [Test]
        public void Test_Sum_OZeroOneNegativeNumbers()
        {
            long actual = Summator.Sum(new int[] { 0, -9 });

            Assert.That(actual == -9);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = Summator.Sum(new int[] { });

            Assert.That(actual == 0);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            long actual = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(8000000000, actual);
        }

        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
            double actual = Summator.Average(new int[] { 5, 10 });

            double expected = 7.5;

            Assert.That(expected == actual);
        }

        public void Test_Average_TwoPossitiveNumbers2()
        {
            double actual = Summator.Average(new int[] { 6, 10 });

            double expected = 8;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Average_OnePositivOneNegativeNumbers()
        {
            double actual = Summator.Average(new int[] { -5, 6 });

            double expected = 0.5;

            Assert.AreEqual(actual, expected);
        }

        public void Test_Average_OnePositivOneNegativeNumbers2()
        {
            double actual = Summator.Average(new int[] { -8, 6 });

            double expected = -1;

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_Average_TwoNegativeNumbers()
        {
            double actual = Summator.Average(new int[] { -5, -6 });

            double expected = - 5.5;

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_Average_TwoNegativeNumbers2()
        {
            double actual = Summator.Average(new int[] { -10, -6 });

            double expected = -8;

            Assert.AreEqual(actual, expected);
        }
    }
}