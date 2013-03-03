using System.Globalization;
using System.Linq;
using System.Numerics;
using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem016
    {
        [Test]
        public void Test()
        {
            var p = BigInteger.Pow(2, 1000);

            int sum = p.ToString().Sum(c => (c - '0'));

            Assert.Inconclusive(sum.ToString(CultureInfo.InvariantCulture));
        }
    }
}