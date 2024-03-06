using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class Uppercase
    {
        static bool UppercaseLetters(string str)
        {
            return (str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && 
                (str[0] <= 90 && str[1] <= 90 && str[2] <= 90);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(UppercaseLetters("day")); // False
            Console.WriteLine(UppercaseLetters("LOL")); // True
            Console.WriteLine(UppercaseLetters("$me1")); // False
        
        }
    }
}
