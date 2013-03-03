using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem014
    {
        [Test]
        public void Test()
        {
            var numberOfSteps = new Dictionary<ulong, ulong>();
            numberOfSteps[1] = 0;

            for (ulong i = 2; i < 1000000; i++)
            {
                ulong j = i;

                ulong num = 0;
                while (true)
                {
                    // Stop when we find a key already there.
                    if (numberOfSteps.ContainsKey(j))
                    {
                        ulong value = num + numberOfSteps[j];
                        numberOfSteps.Add(i, value);
                        break;
                    }

                    if (j%2 == 0)
                    {
                        j = j/2;
                    }
                    else
                    {
                        j = j*3 + 1;
                    }

                    if (j < 1)
                    {
                        
                    }

                    num++;
                }
            }

            ulong max = 0;
            ulong index = 0;
            foreach (ulong a in numberOfSteps.Keys)
            {
                if (numberOfSteps[a] > max)
                {
                    max = numberOfSteps[a];
                    index = a;
                }
            }

            Assert.Inconclusive(index.ToString());
        }
    }
}