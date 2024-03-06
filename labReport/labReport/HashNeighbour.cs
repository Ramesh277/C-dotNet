using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class HashNeighbour
    {
        public static bool IfHasNeighbour(string word)
        {
            return word[0] == word[1] - 1 || word[0] == word[1] + 1 || word[2] == word[1] - 1
           || word[2] == word[1] + 1;
        }
        public static void Main()
        {
            Console.WriteLine(IfHasNeighbour("DCA")); // True
            Console.WriteLine(IfHasNeighbour("PRT")); // False
        }
    }
}
