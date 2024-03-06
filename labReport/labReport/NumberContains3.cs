using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class NumberContains3
    {
        public static bool IfNumberContains3(int n)
        {
            while(n > 0)
 {
                if (n % 10 == 3)
                {
                    return true;
                }
                n /= 10;
            }
            return false;
        }
        public static void Main()
        {
            Console.WriteLine(IfNumberContains3(53)); // true
            Console.WriteLine(IfNumberContains3(0)); // false
            Console.WriteLine(IfNumberContains3(390)); // true
        }

    }
}
