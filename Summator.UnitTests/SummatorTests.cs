namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTwoPossitiveNumbers()
        {
            var numbers = new int[] { 1, 2 };
            var actualResult = Summator.Sum(numbers);
            var expectedResult = 3;
            
            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }

        [Test]
        public void Test_Summator_SumTwoNeggativeNumbers()
        {
            var numbers = new int[] { -1, -2 };
            var actualResult = Summator.Sum(numbers);
            var expectedResult = -3;

            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }

        [Test]
        public void Test_Summator_SumOnePossitiveNumber()
        {
            var numbers = new int[] { 10 };
            var actualResult = Summator.Sum(numbers);
            var expectedResult = 10;

            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }

        [Test]
        public void Test_Summator_ZeroNumbers()
        {
            var numbers = new int[] { };
            var actualResult = Summator.Sum(numbers);
            var expectedResult = 0;

            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }

        [Test]
        public void Test_Summator_BigNumbers()
        {
            var numbers = new int[] { 2000000000, 2000000000, 2000000000 };
            var actualResult = Summator.Sum(numbers);
            var expectedResult = 6000000000;

            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }

        [Test]
        public void Test_Summator_ZeroAndPositiveNumber()
        {
            var numbers = new int[] {0, 7};
            var actualResult = Summator.Sum(numbers);
            var expectedResult = 7;

            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }

        [Test]
        public void Test_Summator_ZeroAndNegativeNumber()
        {
            var numbers = new int[] { 0, -60 };
            var actualResult = Summator.Sum(numbers);
            var expectedResult = -60;

            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }
    }
}