using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class Swap
    {
        public static string SwapTwoNumbers(int a, int b)
        {
            string before = $"Before: a = {a}, b = {b}; ";
            int temp;
            temp = b;
            b = a;
            a = temp;
            string after = $"After: a = {a}, b = {b}";
            return before + after;
        }
        public static void Main()
        {
            Console.WriteLine(SwapTwoNumbers(23, 15)); // Before: a = 23, b = 15; After:a = 15, b = 23
            Console.WriteLine(SwapTwoNumbers(-123, 999)); // Before: a = -123, b = 999; After: a = 999, b = -123
            Console.WriteLine(SwapTwoNumbers(0, 333)); // Before: a = 0, b = 333; After:a = 333, b = 0
        }

    }
}
