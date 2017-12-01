namespace _01.Kitty
{
    using System;
    using System.Linq;

    class Kitty
    {
        static void Main()
        {
            // reading the path for the kitty
            string path = Console.ReadLine();
            int[] instructions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        }
    }
}
