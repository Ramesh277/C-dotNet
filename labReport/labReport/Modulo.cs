using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class Modulo
    {
        public static int ModuloOperations(int a, int b, int c)
        {
            return a % b % c;
        }
        public static void Main()
        {
            Console.WriteLine(ModuloOperations(542, 28, 7)); // 3
            Console.WriteLine(ModuloOperations(33, 10, 2)); // 1
            Console.WriteLine(ModuloOperations(2634, 892, 55)); // 25
        }

    }
}
