using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class FractionSum
    {
        static double Fraction(int num)
        {
            double sum = 0.0;
            for (int i = 1; i <= num; i++)
            {
                sum += (1 / (double)(i * i));
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fraction(2)); // 1.25
            Console.WriteLine(Fraction(7)); // 1.5117970521542
        }
    }
    }
