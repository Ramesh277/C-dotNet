using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class ToThePowerOf
    {
        static double ToPowerOf(int b, int exp)
        {
            double result = 1;
            if (exp == 0)
            {
                return 1;
            }
            for (int i = 1; exp > 0 ? i <= exp : i <= exp * (-1); i++)
            {
                result *= b;
            }
            return exp > 0 ? result : 1 / result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ToPowerOf(10, 0)); // 1
            Console.WriteLine(ToPowerOf(5, -2)); // 0.04
            Console.WriteLine(ToPowerOf(8, -8)); // 5.96046447753
        }
    }
}
