using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem006
    {
        [Test]
        public void Test()
        {
            long squareOfTheSum = 0;
            for (long i = 1; i <= 100; i++)
            {
                squareOfTheSum += i;
            }

            squareOfTheSum = squareOfTheSum * squareOfTheSum;

            long sumOfTheSquares = 0;
            for (long i = 1; i <= 100; i++)
            {
                sumOfTheSquares += i * i;
            }

            Assert.Inconclusive((squareOfTheSum - sumOfTheSquares).ToString());
        }
    }
}