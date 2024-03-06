using System;

namespace labReport
{
    internal class ElementaryOperationsTask
    {
        public static string ElementaryOperations(int a, int b)
        {
            int addition = a + b;
            int substraction = a - b;
            int multiplication = a * b;
            double division;
            if (b != 0)
            {
                division = a / (double)b;
            }
            else // assume that division by 0 returns 0
            {
                division = 0;
            }
            return String.Format($"a + b = {addition}, a - b = {substraction}, a * b = {multiplication}, a / b = {division}");
        }
        public static void Main()
        {
            Console.WriteLine(ElementaryOperations(3, 5)); // a + b = 51, a - b = 21, a * b = 540, a / b = 2.4
        Console.WriteLine(ElementaryOperations(-3, 2)); // a + b = -350, a - b = -      400, a* b = -9375, a / b = -15
        }
    }
}
