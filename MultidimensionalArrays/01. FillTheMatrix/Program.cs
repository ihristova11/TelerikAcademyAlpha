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
                            matrix[cols, rows] = counter;
                            counter++;
                            // Console.WriteLine(counter);
                            //SetMatrixElement(matrix, rows, cols, counter);
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
                                matrix[cols, rows] = counter;
                            }
                            else
                            {
                                matrix[cols, n - rows - 1] = counter;
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
                        downB = i - 1;

                        while(downB != 0)
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

                    PrintTheMatrix(matrix, n);

                    break;


                case 'd':
                    break;

                default:
                    break;
            }

            //Console.WriteLine(counter);
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
                    Console.Write(string.Join(" ", matrix[cols, rows]).PadLeft(4));
                }
                Console.WriteLine();
            }
        }
    }
}
