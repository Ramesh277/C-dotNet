using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class LeapYear
    {
        static bool ISYearLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ISYearLeap(2020)); // True
            Console.WriteLine(ISYearLeap(1719)); // False
        }
    }
}
