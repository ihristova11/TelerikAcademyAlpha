namespace _03.Hops
{
    using System;

    class Hops
    {
        static string[] field;
        static string[] coppied;
        static int maxSum = int.MinValue;
        static int currSum = 0;

        static void Main()
        {
            // read the input string
            string line = Console.ReadLine();
            field = line.Split(',');
            coppied = new string[field.Length];
            //Console.WriteLine(field.Length);
            // copy the array
            Array.Copy(field, coppied, field.Length);
            //Console.WriteLine(string.Join("-", coppied));
            //read the number of instructions
            int m = int.Parse(Console.ReadLine());

            //read all the different lines of instructions
            for (int j = 0; j < m; j++)
            {
                // read the instructions from the console
                string directions = Console.ReadLine();
                string[] directionsArray = directions.Split(',');

                CalculateSum(field, directionsArray);
            }

            Console.WriteLine(maxSum);
        }

        // method for hopping through the array(field)
        static void CalculateSum(string[] field, string[] directionsArray)
        {
            Array.Copy(coppied, field, field.Length);

            int sum = int.Parse(field[0]);
            field[0] = "a";
            int position = 0;
            int i = 0;
            for (i = 0; i < directionsArray.Length; i++)
            {
                position += int.Parse(directionsArray[i]);

                if (position >= field.Length || position < 0 || field[position] == "a")
                {
                    break;
                }
                else
                {
                    sum += int.Parse(field[position]);
                    field[position] = "a";
                    if (i == directionsArray.Length - 1) i = -1;
                }
            }


            //while (i >= 0 && i < directionsArray.Length)
            //{
            //    position += int.Parse(directionsArray[i]);

            //    if (position >= field.Length || position < 0 || field[position] == "a")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        sum += int.Parse(field[position]);
            //        field[position] = "a";
            //        if (i == directionsArray.Length - 1) i = 0;

            //        i++;
            //    }
            //}

            currSum = sum;
            maxSum = maxSum < currSum ? currSum : maxSum;
            // Console.WriteLine(currSum);
        }
    }
}
