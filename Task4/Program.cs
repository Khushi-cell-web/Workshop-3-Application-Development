namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of WeekdayDisplayer to show the name of the selected day
            WeekdayDisplayer weekday = new WeekdayDisplayer();

            // Call the method to display the corresponding day name based on user input
            weekday.ShowDayName();
        }
    }
}