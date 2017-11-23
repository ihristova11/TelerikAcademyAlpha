namespace _01.FillTheMatrix
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char type = char.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int rows;
            int cols;
            int counter = 1;

            switch (type)
            {
                //working
                case 'a':
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

                    break;

                //working
                case 'b':
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

                    break;


                case 'c':

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


        public static void SetMatrixElement(int[,] matrix, int rows, int cols, int counter)
        {
            matrix[rows, cols] = counter;
            counter++;
        }

        public static void PrintTheMatrix(int[,] matrix, int n)
        {
            int rows = 0, cols = 0;
            for (rows = 0; rows < n; rows++)
            {
                for (cols = 0; cols < n; cols++)
                {
                    Console.Write(string.Join(" ", matrix[rows, cols]).PadLeft(4));
                }
                Console.WriteLine();
            }
        }
    }
}
