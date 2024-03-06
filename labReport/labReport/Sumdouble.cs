using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class Sumdouble
    {
        static double SumDoubleOnly(object[] obj)
        {

            double sum = 0.0;
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i] is double)
                {
                    sum += (double)obj[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumDoubleOnly(new object[] { 8.9, "dog", 6, 'c', null, 15.99, 745, true })); // 24.89
        }
    }

    }
