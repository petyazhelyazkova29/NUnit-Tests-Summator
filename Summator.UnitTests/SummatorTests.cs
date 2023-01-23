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

    }
}