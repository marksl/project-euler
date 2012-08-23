using System.Linq;
using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem005
    {
        [Test]
        public void Test()
        {
            int num;

            for (int i = 20;; i += 20)
            {
                if (!IsDivisible(i))
                    continue;

                num = i;
                break;
            }

            Assert.Inconclusive(num.ToString());
        }

        private static readonly int[] DivisibleBy = new[] {11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

        private static bool IsDivisible(int i)
        {
            return DivisibleBy.All(j => i%j == 0);
        }
    }
}