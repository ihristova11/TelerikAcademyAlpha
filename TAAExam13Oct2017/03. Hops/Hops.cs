namespace _03.Hops
{
    using System;

    class Hops
    {
        static string[] field;
        static int currSum = 0;
        static void Main()
        {
            // good > 0
            // bad < 0
            int maxSum = int.MinValue;
            // read the input string
            string line = Console.ReadLine();
            field = line.Split(',');
            int m = int.Parse(Console.ReadLine());
            for (int j = 0; j < m; j++)
            {
                string directions = Console.ReadLine();
                string[] directionsArray = directions.Split(',');

                int sum = int.Parse(field[0]);
                int position = 0;

                for (int i = 0; i < directionsArray.Length; i++)
                {
                    while (position >= 0 && position < directionsArray.Length)
                    {
                        if(i >= directionsArray.Length && position >= 0 && position < directionsArray.Length)
                        {
                            i = 0;
                        }
                        position += int.Parse(directionsArray[i]);

                        sum += int.Parse(field[position]);

                        if (maxSum < sum)
                        {
                            maxSum = sum;
                        }
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
