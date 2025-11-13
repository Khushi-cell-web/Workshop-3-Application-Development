using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Loops
    {
        public static void SumFromOneToN()
        {
            // Prompt the user to enter a positive integer
            Console.Write("Enter a number (N): ");
            int limit = int.Parse(Console.ReadLine());

            int totalSum = 0;

            // Loop through numbers from 1 to N and calculate the total sum
            for (int i = 1; i <= limit; i++)
            {
                totalSum += i;
            }

            // Display the result
            Console.WriteLine($"Sum from 1 to {limit} = {totalSum}");
        }

        
        public static void PrintNumbersWhileLoop()
        {
            int number = 1;

            while (number <= 20)
            {
                // Skip multiples of 4
                if (number % 4 == 0)
                {
                    number++;
                    continue;
                }

                // Stop the loop when the number reaches 15
                if (number == 15)
                    break;

                // Print the current number
                Console.WriteLine(number);

                number++;
            }
        }

       
        public static void SumArrayElements()
        {
            // Declare and initialize an integer array
            int[] values = { 2, 4, 6, 8, 10 };
            int totalSum = 0;

            // Loop through each element in the array and add it to totalSum
            foreach (int value in values)
            {
                totalSum += value;
            }

            // Display the total sum of array elements
            Console.WriteLine($"Sum of all array elements = {totalSum}");
        }
    }
}
