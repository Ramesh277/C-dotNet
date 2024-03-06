using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class PositiveNegative
    {
        static string PositiveNegativeOrZero(double num)
        {
            if (num > 0.0)
            {
                return "Positive";
            }
            else if (num < 0.0)
            {
                return "Negative";
            }
            return "Zero";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PositiveNegativeOrZero(3.14)); // Positive
            Console.WriteLine(PositiveNegativeOrZero(0.0)); // Zero
            Console.WriteLine(PositiveNegativeOrZero(-2.5)); // Negative
        }
        }
    }
