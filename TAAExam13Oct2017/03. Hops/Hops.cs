namespace _03.Hops
{
    using System;

    class Hops
    {
        static string[] field;
        static int maxSum = int.MinValue;
        static int currSum = 0;
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
                FindSum(directionsArray);
            }

        }

        // method for finding diff sums
        static void FindSum(string[] directionsArray)
        {
            int sum = 0;
            int position = 0;
            for (int i = 0; i < directionsArray.Length; i++)
            {
                sum += int.Parse(field[position]);
                position += int.Parse(directionsArray[i]);
                if(position < 0 || position > field.Length - 1)
                {
                    currSum = sum;
                    FindMaxSum();
                    break;
                }
            }
        }

        // method for finding maximal sum
        static void FindMaxSum()
        {
            maxSum = currSum > maxSum ? currSum : maxSum;
        }
    }
}
