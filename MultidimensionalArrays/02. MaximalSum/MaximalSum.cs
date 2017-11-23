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
        public static int rows;
        public static int cols;
        public static int i;
        public static int j;

        static void Main()
        {
            //reading the input
            string line = Console.ReadLine();
            int[] input = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            rows = input[0];
            cols = input[1];

            array = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[cols];
                array[i] = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (i = 0; i <= rows - 3; i++)
            {
                for (j = 0; j <= cols - 3; j++)
                {
                    CalculateSum();
                }
            }
            Console.WriteLine(maxSum);
        }

        public static void CalculateSum()
        {
            int tempRow = i;
            int tempCol = j;

            for (row = i; row < tempRow + 3; row++)
            {
                for (col = j;  col < tempCol + 3; col++)
                {
                    currSum += array[row][col];
                }                
            }
            maxSum = maxSum < currSum ? currSum : maxSum;
            currSum = 0;
        }
    }
}