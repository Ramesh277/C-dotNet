using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class SortAscending
    {
        static bool IfSortedAscending(int[] arr)
        {
            return arr[0] <= arr[1] && arr[1] <= arr[2];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IfSortedAscending(new int[] { 3, 6, 9 })); // True
            Console.WriteLine(IfSortedAscending(new int[] { 34, 17, 90 })); // 
        }
    }
}
