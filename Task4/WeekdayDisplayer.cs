using System;

namespace Task4
{
    internal class WeekdayDisplayer
    {
        public void ShowDayName()
        {
            // Prompt the user to enter a number corresponding to a day of the week
            Console.Write("Please enter a number (1–7) to display the corresponding day: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Use a switch statement to determine and display the name of the day
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                    break;
            }
        }
    }
}