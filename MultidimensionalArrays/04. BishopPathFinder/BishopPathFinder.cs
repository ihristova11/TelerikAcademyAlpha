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

        // method for filling the matrix
        public static void FillTheMatrix()
        {
            int[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            rows = input[0];
            cols = input[1];
            matrix = new int[rows, cols];
            matrix[rows - 1, 0] = 0;
            int num = 0;

            for (int i = 1; i < rows * 2 - 1; i++)
            {
                int row;
                int col;
                if (i < rows)
                {
                    row = rows - i - 1;
                    col = 0;
                    num += 3;
                    for (int j = 0; j <= i; j++)
                    {
                        matrix[row, col] = num;


                        row++;
                        col++;
                    }
                }
                else
                {
                    row = 0;
                    col = i - rows + 1;
                    num += 3;
                    for (int j = 0; j < 2 * rows - i - 1; j++)
                    {
                        matrix[row, col] = num;

                        row++;
                        col++;
                    }
                }
            }

        }

        // method for printing the matrix
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

