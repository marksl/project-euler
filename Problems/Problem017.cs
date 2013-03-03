using System.Globalization;
using System.Linq;
using System.Numerics;
using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem017
    {
        [Test]
        public void Test()
        {
            int sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                var c = new NumberToWordsConverter();
                string word = c.NumberToWords(i);
                word = word.Replace("-", "");
                word = word.Replace(" ", "");

                sum += word.Length;
            }

            Assert.Inconclusive(sum.ToString(CultureInfo.InvariantCulture));
        }
    }
}