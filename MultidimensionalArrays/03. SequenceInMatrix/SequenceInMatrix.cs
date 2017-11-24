namespace _03.SequenceInMatrix
{
    using System;
    using System.Linq;

    class SequenceInMatrix
    {
        public static int rows;
        public static int cols;
        public static int[][] array;
        public static int maxLen = 0;
        public static int currLen = 1;

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
            CalculateLine();
            CalculateColumn();
            //CalculateDiagonalLeft();
            CalculateDiagonalRight();
            Console.WriteLine(maxLen);

        }

        public static void CalculateLine()
        {
            for (int i = 0; i < rows; i++)
            {
                currLen = 1;

                for (int j = 1; j < cols; j++)
                {
                    if (array[i][j - 1] == array[i][j])
                    {
                        currLen++;
                    }
                    else
                    {
                        currLen = 1;
                    }
                    maxLen = maxLen < currLen ? currLen : maxLen;
                }
            }
        }

        public static void CalculateColumn()
        {
            for (int i = 0; i < cols; i++)
            {
                currLen = 1;
                for (int j = 1; j < rows; j++)
                {
                    if (array[j - 1][i] == array[j][i])
                    {
                        currLen++;
                    }
                    else
                    {
                        currLen = 1;
                    }
                    maxLen = maxLen < currLen ? currLen : maxLen;
                }
            }
        }

        public static void CalculateDiagonalRight()
        {
            currLen = 1;
            //for (int i = 0, j = 0; j < cols; i++)
            //{
            //    for (int startR = i, startC = j; ;)
            //    {
            //        if (((startR + 1) < rows) && ((startC + 1) < cols))
            //        {
            //            startR++;
            //            startC++;

            //            if (array[startR][startC] == array[startR - 1][startC - 1])
            //            {
            //                currLen++;
            //            }
            //            else
            //            {
            //                currLen = 1;
            //            }
            //            maxLen = maxLen < currLen ? currLen : maxLen;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }

            //    if (i != 0)
            //    {
            //        i++;
            //    }
            //    else
            //    {
            //        j++;
            //    }
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        for (int x = i, y = j; x < rows && y < cols; x++, y++)
            //        {
            //            if (array[x][y] == array[x - 1][y - 1])
            //            {
            //                currLen++;
            //            }
            //            else
            //            {
            //                currLen = 1;
            //            }
            //        }

            //        for (int x = i, y = cols - 1; x < rows && y >= 0; x++, y--)
            //        {
            //            if (array[x][y] == array[x - 1][y - 1])
            //            {
            //                currLen++;
            //            }
            //            else
            //            {
            //                currLen = 1;
            //            }
            //        }
            //    }
            //}
            
            //cols = 0; rows--;
            //array[rows][cols] = counter;
            //int downB;

            //for (int i = 2; i <= n; i++)
            //{
            //    cols = 0;
            //    rows = n - i;
            //    downB = i - 1;

            //    while (downB != 0)
            //    {
            //        matrix[rows, cols] = counter;
            //        cols++;
            //        rows++;
            //        counter++;
            //        downB--;
            //        if (rows == n - 1)
            //        {
            //            matrix[rows, cols] = counter;
            //            counter++;
            //        }
            //    }
            //}
            //for (int j = n - 1; j >= 0; j--)
            //{
            //    rows = 0;
            //    cols = n - j;
            //    downB = j - 1;
            //    while (downB > 0)
            //    {
            //        matrix[rows, cols] = counter;
            //        cols++;
            //        rows++;
            //        counter++;
            //        downB--;
            //        if (cols == n - 1)
            //        {
            //            matrix[rows, cols] = counter;
            //            counter++;
            //        }
            //    }
            //    if (rows == 0 && cols == n - 1)
            //    {
            //        matrix[rows, cols] = counter;
            //    }
            //}


            maxLen = maxLen < currLen ? currLen : maxLen;
                currLen = 0;
            
        }

        //public static void CalculateDiagonalLeft()
        //{
        //    for (int i = rows - 1, j = cols - 1; j >= 0;)
        //    {
        //        for (int startR = i, startC = j; ;)
        //        {
        //            if (((startR + 1) < rows) && ((startC + 1) < cols))
        //            {
        //                startR++;
        //                startC++;

        //                if (array[startC][startR] == array[startC - 1][startR - 1])
        //                {
        //                    currLen++;
        //                }
        //                else
        //                {
        //                    maxLen = maxLen < currLen ? currLen : maxLen;
        //                    currLen = 0;
        //                }
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }

        //        if (i != 0)
        //        {
        //            i--;
        //        }
        //        else
        //        {
        //            j++;
        //        }

        //        maxLen = maxLen < currLen ? currLen : maxLen;
        //        currLen = 0;
        //    }
        //}
    }
}
