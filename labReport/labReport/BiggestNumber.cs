using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class BiggestNumber
    {
        static int TheBiggestNumber(int[] numArr)
        {
            int theBiggest = numArr[0];
            for (int i = 1; i < numArr.Length; i++)
            {
                if (numArr[i] > theBiggest)
                {
                    theBiggest = numArr[i];
                }
            }
            return theBiggest;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(TheBiggestNumber(new int[] { 9, 4, 8, 1, 0, 2 }));
            // 9
            Console.WriteLine(TheBiggestNumber(new int[] { -34, -54, -7, -40, -123, -99 }));
        }
        }
}
