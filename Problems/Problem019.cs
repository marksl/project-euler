using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem019
    {
        [Test]
        public void Test()
        {
            // 1 Jan 1900 was a Monday.
            
            int day = 1;
            int numSundays = 0;

            for (int year = 1901; year < 2000; year++)
            {
                // 5200 sundays
                for (int month = 1; month <= 12; month++)
                {
                    // Thirty days has September, April, June and November.

                    // All the rest have thirty-one,

                    // Saving February alone,
                    // Which has twenty-eight, rain or shine.
                    // And on leap years, twenty-nine.
                    // A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
                    switch (month)
                    {
                        case 1: // Jan
                            day += 31;
                            break;
                        
                        case 2: // Feb
                            if ((year%100 != 0) && ((year%4 == 0))
                                || ((year%100 == 0) && (year%400 == 0)))
                                day += 29;
                            else day += 28;
                            break;

                        case 3: // Mar
                            day += 31;
                            break;

                        case 4: // Apr
                            day += 30;
                            break;

                        case 5: // May
                            day += 31;
                            break;

                        case 6: // June
                            day += 30;
                            break;

                        case 7: // Jul
                            day += 31;
                            break;

                        case 8: // Aug
                            day += 31;
                            break;

                        case 9: // Sep
                            day += 30;
                            break;

                        case 10: // Oct
                            day += 31;
                            break;

                        case 11: // Nov
                            day += 30;
                            break;

                        case 12: // Dec
                            day += 31;
                            break;
                    }

                    day = day%7;

                    if (day == 0)
                    {
                        numSundays++;
                    }
                }
            }

            Assert.Inconclusive(numSundays.ToString());


        }
    }
}