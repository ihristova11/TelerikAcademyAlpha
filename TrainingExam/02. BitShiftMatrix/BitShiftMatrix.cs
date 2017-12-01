namespace _02.BitShiftMatrix
{
    using System;
    using System.Linq;

    class BitShiftMatrix
    {
        public static int r;
        public static int c;
        public static int[,] matrix;
        public static int numberOfMoves;
        public static int[,] valuesOfRC;
        public static int[] codes;
        static int coeff;
        static void Main()
        {
            //reading the input
            int[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //assign values to r an c
            r = input[0];
            c = input[1];

            matrix = new int[r, c];

            numberOfMoves = int.Parse(Console.ReadLine());

            //array for the read codes
            codes = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //find the coefficient
            coeff = r < c ? c : r;

            //array for holding the coordinates of points
            valuesOfRC = new int[2, numberOfMoves];

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

        public static void CalculateValues()
        {
            for (int i = 0; i < numberOfMoves; i++)
            {
                valuesOfRC[0, numberOfMoves] = codes[numberOfMoves] % coeff; //wanted cols
                valuesOfRC[1, numberOfMoves] = codes[numberOfMoves] / coeff; //wanted rows
            }
        }
    }
}
