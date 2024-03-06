using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class EvenNumber
    {
        static bool IfNumberIsEven(int num)
        {
            return num % 2 == 0;
        }
        static void Main()
        {
            Console.WriteLine(IfNumberIsEven(8)); // True
            Console.WriteLine(IfNumberIsEven(9));
        }
    }
}
