using System;

class AppearanceCount
{
    static void CountAppearences(string[] array, int number)
    {
        int counter = 0;
        for (int count = 0; count < array.Length; count++)
        {
            if (int.Parse(array[count]) == number)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        var array = Console.ReadLine().Split(' ');
        int number = int.Parse(Console.ReadLine());
        CountAppearences(array, number);
    }
}