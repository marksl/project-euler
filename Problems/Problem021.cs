using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem021
    {
        [Test]
        public void Test()
        {
            int sum = 0;
            for (int i = 1; i < 10000; i++)
            {
                int a = MathUtils.GetSumOfProperDivisors(i);
                int b = MathUtils.GetSumOfProperDivisors(a);

                // They are amicable
                if (b == i)
                {
                    if (a != b)
                    {
                        // todo: Need to filter dups. currently 284 and 220 are added twice

                        // todo: also check if a or b is over 10000
                        sum += a;
                        //sum += b;
                    }
                }
            }

            Assert.Inconclusive(sum.ToString());
        }

        
    }
}
