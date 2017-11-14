using System;

class GuessTheDate
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());

        string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        //string output = "";

        // jan - 31 feb - 30 march - 31 apr - 30 may - 31, june - 30 
        // july - 31, aug - 31, sept - 30, oct - 31, nov - 30, dec - 31

        //check for first day of month
        if (day == 1)
        {
            
            if (month != 1)
            {
                month = month - 1;
                // for Feb in harvest year
                if (year % 4 == 0 && month == 2)
                {
                    day = days[month - 1] + 1;
                }
                else 
                {
                    day = days[month - 1];
                }
            }
            else // DECEMBER case
            {
                month = 12;
                day = 31;
                year = year - 1;
            }
        }
        else 
        {
            day = day - 1;
        }
        //output += "{0}-{1}-{2}", day, months[month + 1], year;
        Console.WriteLine("{0}-{1}-{2}", day, months[month - 1], year);
    }
}

