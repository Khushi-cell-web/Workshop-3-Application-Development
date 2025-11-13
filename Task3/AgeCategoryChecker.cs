using System;

namespace Task3
{
    internal class AgeCategoryChecker
    {
        public void DetermineAgeGroup()
        {
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();

            // Validate user input
            if (int.TryParse(input, out int userAge))
            {
                if (userAge < 0 || userAge > 120)
                {
                    Console.WriteLine("Please enter a realistic age between 0 and 120.");
                }
                else if (userAge < 13)
                {
                    Console.WriteLine("You belong to the Child category.");
                }
                else if (userAge <= 19)
                {
                    Console.WriteLine("You belong to the Teenager category.");
                }
                else
                {
                    Console.WriteLine("You belong to the Adult category.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value for age.");
            }
        }
    }
}