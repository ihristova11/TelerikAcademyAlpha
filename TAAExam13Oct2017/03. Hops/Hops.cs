namespace _03.Hops
{
    using System;

    class Hops
    {
        static string[] field;
        static int maxSum = 0;
        static int currSum = 0;

        static void Main()
        {
            // read the input string
            string line = Console.ReadLine();
            field = line.Split(',');

            //read the number of instructions
            int m = int.Parse(Console.ReadLine());

            //read all the different lines of instructions
            for (int j = 0; j < m; j++)
            {
                // read the instructions from the console
                string directions = Console.ReadLine();
                string[] directionsArray = directions.Split(',');

               
            }

            Console.WriteLine(maxSum);
        }

        // method for hopping through the array(field)
        static void CalculateSum(string[] field, string[] directionsArray)
        {
            int sum = int.Parse(field[0]);
            field[0] = "a";
            int position = 0;

            for (int i = 0; i < directionsArray.Length; i++)
            {
                position += int.Parse(directionsArray[i]);

                if(position >= field.Length || position < 0 || field[position] == "a")
                {
                    break;
                }
                else
                {
                    sum += int.Parse(field[position]);
                }
            }
            currSum = sum;
        }

        static int MaxSum(int currSum, int maxSum)
        {
            maxSum = maxSum < currSum ? currSum : maxSum;

            return maxSum;
        }
    }
}
