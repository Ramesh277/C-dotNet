using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class BitNumber
    {
        static int BitsToNumber(string bits)
        {
            var number = 0;
            for (var i = 0; i < bits.Length; i++)
            {
                number += (int)(char.GetNumericValue(bits[i]) * Math.Pow(2, bits.Length - i -
               1));
            }
            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(BitsToNumber("0")); // 0
            Console.WriteLine(BitsToNumber("00001011000001")); // 705
            Console.WriteLine(BitsToNumber("10001110001010100")); // 72288
        }
    }
}
