using System.Collections.Generic;
using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem024
    {
        [Test]
        public void Test()
        {
            List<string> strings = Permute.GetPermutations("0123456789");

            strings.Sort();

            Assert.Inconclusive(strings[999999]);
        }
    }
}