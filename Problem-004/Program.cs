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
                    string s = product.ToString();

                    if (product < 100000)
                    {
                        // 5 digit pallindrome
                        if ((s[0] == s[4]) && (s[1] == s[3]))
                        {
                            if (product > largest)
                                largest = product;
                        }
                    }
                    else
                    {
                        // 6 digit pallindrome
                        if ((s[0] == s[5]) && (s[1] == s[4]) && (s[2] == s[3]))
                        {
                            if (product > largest)
                                largest = product;
                        }
                    }
                }
            }

            Console.Out.WriteLine(largest);
            Console.ReadLine();
        }
    }
}