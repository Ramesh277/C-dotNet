using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class IncreasingAdjacent
    {
        static bool ThreeIncreasingAdjacent(int[] arr)
        {
            bool found = false;
            for (int i = 1; i <= arr.Length - 2; i++)
            {
                if (arr[i - 1] + 1 == arr[i] && arr[i + 1] - 1 == arr[i])
                {
                    found = true;
                }
            }
            return found;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 7, 8, 9, 2, 4, 5, 0 }));
            // True
            Console.WriteLine(ThreeIncreasingAdjacent(new int[] { -9, 0, -1, -6, -5, -4, -8, 0 }));
        }
        }
}
