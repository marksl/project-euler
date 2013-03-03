using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem012
    {
        [Test]
        public void Test()
        {
            foreach (int triangularNumber in GetTriangularNumbers())
            {
                var factorsCount = GetFactorsFast(triangularNumber);
                if (factorsCount > 500)
                {
                    Assert.Inconclusive(triangularNumber.ToString());
                }
            }
        }

        private int GetFactorsFast(int number)
        {
            var factors = new List<int>();
            var max = (int) Math.Sqrt(number);
            for (int factor = 1; factor <= max; ++factor)
            {
                if (number%factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number/factor)
                    {
                        factors.Add(number/factor);
                    }
                }
            }
            return factors.Count;
        }

        private static IEnumerable<int> GetTriangularNumbers()
        {
            int triangularNumber = 0;
            int i = 1;
            while(true)
            {
                triangularNumber += i;

                yield return triangularNumber;
                i++;
            }
        }
    }
}