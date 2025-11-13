using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculate and display the sum of numbers from 1 to N
            Loops.SumFromOneToN();

            // Print numbers from 1 to 20
            // Skip multiples of 4 and stop when the number reaches 15
            Loops.PrintNumbersWhileLoop();
            
            // Calculate and display the sum of all array elements
            Loops.SumArrayElements();

            // Pause the console so the output remains visible
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}