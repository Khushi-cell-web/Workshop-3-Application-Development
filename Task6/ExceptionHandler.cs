using System;

namespace Task6
{
    internal class ExceptionHandler
    {
        // Method to safely convert user input to an integer
        public static void ConvertUserInputToInteger()
        {
            try
            {
                Console.Write("Please enter a number: ");
                string userInput = Console.ReadLine();
                int convertedNumber = Convert.ToInt32(userInput);
                Console.WriteLine("You entered: " + convertedNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: The entered value is not a valid number.");
            }
            finally
            {
                Console.WriteLine("Execution completed successfully.");
            }
        }

        // Method to validate password using the 'throw' keyword
        public static void ValidatePassword()
        {
            try
            {
                Console.Write("Enter your password: ");
                string userPassword = Console.ReadLine();

                if (userPassword.Length < 6)
                {
                    throw new Exception("Password must contain at least 6 characters.");
                }

                Console.WriteLine("Password meets the required conditions.");
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }
    }
}