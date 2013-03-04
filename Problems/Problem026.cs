
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using NUnit.Framework;
using Numerics;

namespace Problems
{
    [TestFixture]
    public class Problem026
    {
        [Test]
        public void Test()
        {

            int results = 7%13;
            int results2 = 70%13;
            int results3 = 50%13;


            // Interesting. todo - long division

            // http://stackoverflow.com/questions/8946310/how-to-know-the-repeating-decimal-in-a-fraction

            int maxRepeating = 0;
            int maxRepeatingI = 0;

            for (int i = 2; i < 1000; i++)
            {
                int num = 1;
                var remainders = new Dictionary<int, int>();

                int remainder = 1;
                while (true)
                {
                    remainder = remainder%i;

                    // Not Repeating
                    if (remainder == 0)
                        break;

                    if (remainders.ContainsKey(remainder))
                    {
                        int newMax = num-remainders[remainder];
                        if (newMax > maxRepeating)
                        {
                            maxRepeating = newMax;
                            maxRepeatingI = i;
                        }

                        break;
                    }

                    remainders.Add(remainder, num++);
                    remainder *= 10;
                }
            }

            Assert.Inconclusive(maxRepeatingI.ToString());

        }
         
    }
}