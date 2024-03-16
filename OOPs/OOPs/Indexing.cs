using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Indexing
    {
        private string[] data = new string[10];
        public string this[int index]
        {
            get
            {
                // Return the value at the specified index
                return data[index];
            }
            set
            {
                // Set the value at the specified index
                data[index] = value;
                Console.WriteLine($"Value at index {index} set to {value}");
            }
        }

        public static void Main()
        {
            Indexing ind = new Indexing();
            ind[0] = "rahul"; // This will set the value at index 0
            string valueAtIndex0 = ind[0]; // This will retrieve the value at index 0
            Console.WriteLine($"Value at index 0: {valueAtIndex0}");

        }
    }
}
