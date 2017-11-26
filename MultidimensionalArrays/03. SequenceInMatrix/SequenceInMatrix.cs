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
        //working
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
        //working
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
            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    for (int r = i, c = j; r < array.GetLength(0) - 1 && c < array.GetLength(1) - 1; r++, c++)
                    {
                        if (array[r][c] == array[r + 1][c + 1])
                        {
                            currLen++;
                        }
                        else
                        {
                            currLen = 1;
                        }
                        maxLen = maxLen < currLen ? currLen : maxLen;
                    }
                    currLen = 1;
                }
            }

        }

        public static void CalculateDiagonalLeft()
        {
            for (int i = rows - 1, j = cols - 1; j >= 0;)
            {
                for (int startR = i, startC = j; ;)
                {
                    if (((startR + 1) < rows) && ((startC + 1) < cols))
                    {
                        startR++;
                        startC++;

                        if (array[startC][startR] == array[startC - 1][startR - 1])
                        {
                            currLen++;
                        }
                        else
                        {
                            maxLen = maxLen < currLen ? currLen : maxLen;
                            currLen = 0;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (i != 0)
                {
                    i--;
                }
                else
                {
                    j++;
                }

                maxLen = maxLen < currLen ? currLen : maxLen;
                currLen = 0;
            }
        }




    }
}
