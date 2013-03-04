using System.Numerics;
using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem025
    {
        [Test]
        public void Test()
        {
            BigInteger prev = 1;
            BigInteger next = 1;

            int term = 3;
            while (true)
            {
                BigInteger temp = next + prev;

                prev = next;
                next = temp;

                string s = temp.ToString();
                if (s.Length == 1000)
                {
                    Assert.Inconclusive(term.ToString());
                }

                term++;
            }
        }
         
    }
}