﻿namespace _01.FillTheMatrix
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
            char type = char.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            switch (type)
            {
                case 'a':
                    CalculateCaseA(matrix, n);
                    break;
                    
                case 'b':
                    CalculateCaseB(matrix, n);
                    break;

                case 'c':
                    CalculateCaseC(matrix, n);
                    break;

                case 'd':
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
                    break;

                default:
                    break;
            }
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

        public static void CalculateCaseC(int[,] matrix, int n)
        {
            counter = 1;
            cols = 0; rows = n - 1;
            matrix[rows, cols] = counter;
            counter++;
            int downB;

            for (int i = 2; i <= n; i++)
            {
                cols = 0;
                rows = n - i;
                downB = i - 1;

                while (downB != 0)
                {
                    matrix[rows, cols] = counter;
                    cols++;
                    rows++;
                    counter++;
                    downB--;
                    if (rows == n - 1)
                    {
                        matrix[rows, cols] = counter;
                        counter++;
                    }
                }
            }
            for (int j = n - 1; j >= 0; j--)
            {
                rows = 0;
                cols = n - j;
                downB = j - 1;
                while (downB > 0)
                {
                    matrix[rows, cols] = counter;
                    cols++;
                    rows++;
                    counter++;
                    downB--;
                    if (cols == n - 1)
                    {
                        matrix[rows, cols] = counter;
                        counter++;
                    }
                }
                if (rows == 0 && cols == n - 1)
                {
                    matrix[rows, cols] = counter;
                }
            }
            PrintTheMatrix(matrix, n);
        }

        public static void CalculateCaseB(int[,] matrix, int n)
        {
            matrix[0, 0] = counter;
            for (cols = 0; cols < n; cols++)
            {
                for (rows = 0; rows < n; rows++)
                {
                    if (cols % 2 == 0)
                    {
                        matrix[rows, cols] = counter;
                    }
                    else
                    {
                        matrix[n - rows - 1, cols] = counter;
                    }
                    counter++;
                }
            }
            PrintTheMatrix(matrix, n);
        }

        public static void CalculateCaseA(int[,] matrix, int n)
        {
            matrix[0, 0] = counter;

            for (cols = 0; cols < n; cols++)
            {
                for (rows = 0; rows < n; rows++)
                {
                    matrix[rows, cols] = counter;
                    counter++;
                }
            }
            PrintTheMatrix(matrix, n);
        }

        public static void PrintTheMatrix(int[,] matrix, int n)
        {
            int rows = 0, cols = 0;
            for (rows = 0; rows < n; rows++)
            {
                for (cols = 0; cols < n; cols++)
                {
                    if (cols == n - 1)
                    {
                        Console.Write("{0}", matrix[rows, cols]);
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
