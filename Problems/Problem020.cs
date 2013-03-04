using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem020
    {
        [Test]
        public void Test()
        {
            BigInteger total = 1;
            for (int i = 1; i <= 100; i++)
            {
                total = total*i;
            }

            ulong sum = 0;
            foreach (char c in total.ToString())
            {
                sum += (ulong)(c - '0');
            }

            Assert.Inconclusive(sum.ToString());
            
        }
    }
}
