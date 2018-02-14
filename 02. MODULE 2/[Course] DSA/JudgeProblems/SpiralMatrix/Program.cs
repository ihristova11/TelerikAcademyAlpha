namespace _01.FillTheMatrix
{
    using System;

    class FillTheMatrix
    {
        public static int counter = 1;
        public static int rows;
        public static int cols;
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            CalculateCaseD(matrix, n);
        }

        public static void CalculateCaseD(int[,] matrix, int n)
        {
            rows = 0;
            cols = 0;
            counter = 1;
            matrix[rows, cols] = counter;

            for (int bound = 0; bound < n / 2 + 1; bound++)
            {
                rows = bound;
                cols = bound;
                for (; rows < n - bound; rows++)
                {
                    if (rows == n - bound - 1)
                    {
                        for (; cols < n - bound; cols++)
                        {
                            matrix[rows, cols] = counter;
                            counter++;
                        }
                    }
                    else
                    {
                        matrix[rows, cols] = counter;
                        counter++;
                    }
                }
                cols = n - bound - 1;
                rows = n - bound - 2;
                for (; rows >= bound; rows--)
                {

                    if (rows == bound)
                    {
                        for (cols = n - bound - 1; cols >= bound + 1; cols--)
                        {
                            matrix[rows, cols] = counter;
                            counter++;
                        }
                    }
                    else
                    {
                        matrix[rows, cols] = counter;
                        counter++;
                    }
                }
            }
            PrintTheMatrix(matrix, n);
        }

        public static void PrintTheMatrix(int[,] matrix, int n)
        {
            int rows = 0, cols = 0;
            for (cols = 0; cols < n; cols++)
            {
                for (rows = 0; rows < n; rows++)
                {
                    if (cols == n - 1)
                    {
                        Console.Write("{0} ", matrix[rows, cols]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[rows, cols]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}