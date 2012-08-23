using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem007
    {
        [Test]
        public void Test()
        {
            var primes = new List<int> { 2, 3, 5, 7, 11, 13 };

            int i = 14;
            while (primes.Count < 10001)
            {
                if (IsPrime(i, primes))
                {
                    primes.Add(i);
                }

                i++;
            }

            Assert.Inconclusive(primes[10000].ToString());
        }

        private static bool IsPrime(int i, IEnumerable<int> primes)
        {
            return primes.All(p => i%p != 0);
        }
    }
}