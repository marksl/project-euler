using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public static class MathUtils
    {
        public static int GetSumOfProperDivisors(int number)
        {
            var factors = new List<int>();
            var max = (int)Math.Sqrt(number);
            for (int factor = 1; factor <= max; ++factor)
            {
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor)
                    {
                        factors.Add(number / factor);
                    }
                }
            }

            factors.Remove(number);

            return factors.Sum();
        }
         
    }
}