using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class Absolute
    {
        static int AbsoluteValue(int number)
        {
            return number >= 0 ? number : number * -1;
        }
        public static void Main()
        {
            Console.WriteLine(AbsoluteValue(2744)); // 2744
            Console.WriteLine(AbsoluteValue(0)); // 0 
            Console.WriteLine(AbsoluteValue(-23)); // 23
        }
      }
    }
