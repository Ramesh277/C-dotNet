using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class SumandAverage
    {
        static string SumAndAverage(int lowest, int highest)
        {
            int sum = 0;
            int range = 0;
            double average = 0.0;
            for (int i = lowest; i <= highest; i++)
            {
                sum += i;
                range++;
            }
            average = sum / (double)range;
            return string.Format($"Sum: {sum}, Average: {average}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumAndAverage(20, 21)); // Sum: 41 Average: 20,5
            Console.WriteLine(SumAndAverage(55, 55)); // Sum: 55 Average: 55
            Console.WriteLine(SumAndAverage(0, 100)); // Sum: 5050 Average: 50
        }
    }
}
