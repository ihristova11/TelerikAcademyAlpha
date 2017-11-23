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
        public static int currLen = 0;
        //public static int counter = 0;

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

        }

        public static void CalculateLine()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if(array[i][j - 1] == array[i][j])
                    {
                        currLen++;
                    }
                    maxLen = maxLen < currLen ? currLen : maxLen;
                    currLen = 0;
                }
            }
        }

        public static void CalculateColumn()
        {
            for (int i = 0; i < cols; i++)
            {
                for (int j = 1; j < rows; j++)
                {
                    if (array[i][j - 1] == array[i][j])
                    {
                        currLen++;
                    }
                    maxLen = maxLen < currLen ? currLen : maxLen;
                    currLen = 0;
                }
            }
        }

        public static void CalculateDiagonal()
        {
            for (int i = 0, j = 0; j < cols;)
            {
                for (int startR = i, startC = j; ; )
                {
                    if (((startR + 1) < rows) && ((startC + 1) < cols))
                    {
                        startR++;
                        startC++;
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
            }        
        }
    }
}
