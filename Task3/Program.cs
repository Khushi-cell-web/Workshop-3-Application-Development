using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of AgeCategoryChecker
            AgeCategoryChecker ageCategory = new AgeCategoryChecker();

            // Call the method to evaluate and display the user's age category
            ageCategory.DetermineAgeGroup();

            // Pause the console before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}