namespace _02.BitShiftMatrix
{
    using System;
    using System.Linq;

    class BitShiftMatrix
    {
        public static int r;
        public static int c;
        public static int[,] matrix;
        static void Main()
        {
            int[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            r = input[0];
            c = input[1];
            matrix = new int[r, c];
            //int numberOfMoves = int.Parse(Console.ReadLine());
            FillTheMatrix();
            PrintTheMatrix();
        }

        //method for filling the matrix
        public static void FillTheMatrix()
        {
            for (int i = r - 1; i >= 0; i--)
            {
                for (int j = 0; j < c; j++)
                {
                    //formula for the value of every element in the matrix
                    matrix[i, j] = (int)(Math.Pow(2, r - 1 - i + j)); 
                }
            }
        }

        public static void PrintTheMatrix()
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write((matrix[i, j] + " ").PadLeft(4));
                }
                Console.WriteLine();
            }
        }
    }
}
