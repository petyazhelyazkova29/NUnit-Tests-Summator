using Summator;

namespace Average.UnitTests
{
    public class AverageTests
    {

        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
            var numbers = new int[] { 5, 15};
            var actualResult = Summator.Average 
            var expectedResult = 6000000000;

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}