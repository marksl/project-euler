using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem003
    {
        [Test]
        public void Test()
        {
            // The prime factors of 13195 are 5, 7, 13 and 29.
            // What is the largest prime factor of the number 600851475143 ?

            long maxPrimeFactor = 0;

            long i = 0;
            long goal = 600851475143;
            while (i++ != goal)
            {
                if (goal % i != 0) continue;
                if (i <= maxPrimeFactor) continue;

                // Found the current largest prime factor.
                maxPrimeFactor = i;
                goal /= i;
                i = 0;
            }

            Assert.Inconclusive(maxPrimeFactor.ToString());
        }
         
    }
}