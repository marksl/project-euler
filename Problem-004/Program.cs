using System;

namespace Problem_004
{
    internal class Program
    {
        private static void Main()
        {
            // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 99.
            // Find the largest palindrome made from the product of two 3-digit numbers.

            // It's either a 5 digit or 6 digit pallindrome.

            int largest = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int product = i*j;
                    string productAsString = product.ToString();
                    
                    char[] productReversed = productAsString.ToCharArray();
                    Array.Reverse(productReversed);

                    if (productAsString.Equals(new string(productReversed)))
                    {
                        if (product > largest)
                            largest = product;
                    }

                }
            }

            Console.Out.WriteLine(largest);
            Console.ReadLine();
        }
    }
}