namespace _04.A_B
{
    using System;
    using System.Linq;

    class AB
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers;
           
            for (int i = 0; i < n; i++)
            {
                numbers = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                Console.WriteLine(numbers[1] + numbers[0]);
            }
        }
    }
}
