namespace _04.BishopPathFinder
{
    using System;
    using System.Linq;

    class BishopPathFinder
    {
        public static int eaten = 0;
        public static int[,] matrix;
        public static int row;
        public static int col;
        public static int rows;
        public static int cols;
        static void Main()
        {
            FillTheMatrix();
            Print();
        }

        public static void FillTheMatrix()
        {
            int[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();            
            rows = input[0];
            cols = input[1];
            matrix = new int[rows, cols];
            matrix[rows - 1, 0] = 0;
            int num = 3;
            for (int i = rows - 2; i >= 0; i--)
            {
                for (int index = 0; index <= Math.Min(rows - 1 - i, cols - 1); index++)
                {
                    matrix[row + index, 0 + index] = num * index;
                }
            }

            for (int Row = 1; Row < rows - 1; Row++)
            {

                for (int curMod = 1; curMod <= Math.Min(Row - 1, cols - 1); curMod++)
                {
                    matrix[Row - curMod, (cols - 1) - curMod] = num * curMod;
                }
            }
        }

        public static void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
