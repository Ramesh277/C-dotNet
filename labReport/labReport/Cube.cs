using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class Cube
    {
        public static double TheCubeOf(double num)
        {
            return num * num * num;
        }
        public static void Main()
        {
            Console.WriteLine(TheCubeOf(15)); // 3375
            Console.WriteLine(TheCubeOf(0.25)); // 0.015625
            Console.WriteLine(TheCubeOf(-12)); // -1728
            Console.WriteLine(TheCubeOf(-0.1)); // -0.00
        }
    }
}
