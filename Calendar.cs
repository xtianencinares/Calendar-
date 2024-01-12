using System;

class SimpleCalendar
{
    static void Main()
    {
        // Specify the month and year
        int month = 1; // January
        int year = 2024;

        DisplayCalendar(month, year);
    }

    static void DisplayCalendar(int month, int year)
    {
        // Get the first day of the month
        DateTime firstDayOfMonth = new DateTime(year, month, 1);

        // Get the number of days in the month
        int daysInMonth = DateTime.DaysInMonth(year, month);

        // Print the header
        Console.WriteLine("  Sun  Mon  Tue  Wed  Thu  Fri  Sat");

        // Print leading spaces
        for (int i = 0; i < (int)firstDayOfMonth.DayOfWeek; i++)
        {
            Console.Write("     ");
        }

        // Print the days
        for (int day = 1; day <= daysInMonth; day++)
        {
            // Adjust spacing
            if (day < 10)
            {
                Console.Write($"    {day}");
            }
            else
            {
                Console.Write($"   {day}");
            }

            // Move to the next line for the start of a new week
            if ((int)(firstDayOfMonth.AddDays(day).DayOfWeek) == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine(); // Move to the next line after printing the calendar
    }
}
