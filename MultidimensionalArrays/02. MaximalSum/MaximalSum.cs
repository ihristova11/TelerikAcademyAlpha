namespace _02.MaximalSum
{
    using System;
    using System.Linq;

    class MaximalSum
    {
        public static int[][] array;
        public static int maxSum = int.MinValue;
        public static int currSum = 0;
        public static int row = 0;
        public static int col = 0;

        static void Main()
        {
            //reading the input
            string line = Console.ReadLine();
            int[] input = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            array = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[cols];
                array[i] = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

        }

        public static void CalculateSum()
        {
            for (; row < row + 3; row++)
            {
                for (; col < col + 3; col++)
                {
                    currSum += array[row][col];
                }
            }

        }
    }
}
