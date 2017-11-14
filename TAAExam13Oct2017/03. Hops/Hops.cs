namespace _03.Hops
{
    using System;

    class Hops
    {
        static string[] field;

        static void Main()
        {
            // good > 0
            // bad < 0

            // read the input string
            string line = Console.ReadLine();
            field = line.Split(',');
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string directions = Console.ReadLine();
                string[] directionsArray = directions.Split(',');
            }

        }

        // method for finding greatest sum
        static void FindSum(string[] directionsArray)
        {
            int sum = 0;
            int hopps = 0;
            for (int i = 0; i < directionsArray.Length; i++)
            {
                hopps = int.Parse(directionsArray[i]);

            }
        }
    }
}
