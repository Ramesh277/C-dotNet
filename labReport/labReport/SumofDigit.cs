using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class SumofDigit
    {
        public static int DigitsSum(uint number)
        {
            int sum = 0;
            int i = 10;
            int j = 1;
            while (number / j >= 1)
            {
                sum += (int)(number % i / j);
                i *= 10;
                j *= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DigitsSum(5)); // 5
            Console.WriteLine(DigitsSum(1029584739)); // 48
            Console.WriteLine(DigitsSum(99999999)); // 72
        }

    }
}
