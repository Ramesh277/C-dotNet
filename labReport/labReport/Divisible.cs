using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class Divisible
    {
        static int DivisibleBy2Or3(int a, int b)
        {
            return (a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0) ? a * b : a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DivisibleBy2Or3(2, 18)); // 36
            Console.WriteLine(DivisibleBy2Or3(7, 0)); // 7
            Console.WriteLine(DivisibleBy2Or3(33, 9)); // 297
            Console.WriteLine(DivisibleBy2Or3(-72, 54)); // -3888
            Console.WriteLine(DivisibleBy2Or3(24, -80)); // -1920
            Console.WriteLine(DivisibleBy2Or3(444, 0)); // 0
        }
    }
}
