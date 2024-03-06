using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class Two7sNext
    {
        static int Two7sNextToEachOther(int[] arr)
        {
            int adjacent7s = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 7 && arr[i + 1] == 7)
                {
                    adjacent7s++;
                }
            }
            return adjacent7s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Two7sNextToEachOther(new int[] { 7, 7, 8, 4, 3, 7, 2, 1, 0, 7 })
           ); // 1
            Console.WriteLine(Two7sNextToEachOther(new int[] { 4, 7, 8, 2, 0, 5, 2, 7, 5, 8 })
           );
        }
        }
}
