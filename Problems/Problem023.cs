using System.Collections.Generic;
using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem023
    {
        [Test]
        public void Test()
        {
            var abundantNumbers = new List<int>();

            // Step 1. Find all abundant numbers
            for (int i = 1; i <= 28123; i++)
            {
                int sum = MathUtils.GetSumOfProperDivisors(i);
                if (sum > i)
                {
                    abundantNumbers.Add(i);
                }
            }

            Assert.IsNotNull(abundantNumbers);

            // Step 2. Find the sum of them all. Put them in a dictionary.
            // n-squared.

            var sumOfTwo = new HashSet<int>();

            foreach (int a in abundantNumbers)
            {
                foreach (int b in abundantNumbers)
                {
                    sumOfTwo.Add(a + b);
                }
            }

            ulong sumThatCannotBeTwoSummed = 0;
            for (int i = 1; i <= 28123; i++)
            {
                if (!sumOfTwo.Contains(i))
                {
                    sumThatCannotBeTwoSummed += (ulong)i;
                }
            }

            Assert.Inconclusive(sumThatCannotBeTwoSummed.ToString());
        }

    }
}