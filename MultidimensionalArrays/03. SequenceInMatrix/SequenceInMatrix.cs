namespace _03.SequenceInMatrix
{
    using System;
    using System.Linq;

    class SequenceInMatrix
    {
        //public static int rows;
        //public static int cols;
        //public static int[][] array;
        //public static int maxLen = 0;
        //public static int currLen = 1;

        static void Main()
        {
            // reading the input
            string sizes = Console.ReadLine();
            string[] rowsAndCols = sizes.Trim(' ').Split(' ');

            //saving the sizes 
            int inputRows = int.Parse(rowsAndCols[0]);
            int inputCols = int.Parse(rowsAndCols[1]);
            string[][] matrix = new string[inputRows][];

            for (int i = 0; i < inputRows; i++)
            {
                matrix[i] = Console.ReadLine().Trim(' ').Split(' ');
            }

            // vars
            int maxLen = 0;
            int currLen = 1;

            // rows check
            for (int row = 0; row < inputRows; row++)
            {
                // reset for each row
                currLen = 1;

                for (int col = 1; col < inputCols; col++)
                {
                    if (matrix[row][col] == matrix[row][col - 1])
                    {
                        currLen++;
                    }
                    else
                    {
                        maxLen = maxLen < currLen ? currLen : maxLen;
                        currLen = 1;
                    }
                }

                // double check for last element on row
                maxLen = maxLen < currLen ? currLen : maxLen;
            }

            // cols check
            for (int col = 0; col < inputCols; col++)
            {
                // reset for each col
                currLen = 1;

                for (int row = 1; row < inputRows; row++)
                {
                    if (matrix[row][col] == matrix[row - 1][col])
                    {
                        currLen++;
                    }
                    else
                    {
                        // check if currLen is longest
                        maxLen = maxLen < currLen ? currLen : maxLen;
                        //reset currLen
                        currLen = 1;
                    }
                }

                // double check currLen for last element
                maxLen = maxLen < currLen ? currLen : maxLen;
            }

            //check diagonals (left diagonal)
            for (int Col = 1; Col < inputCols; Col++)
            {
                currLen = 1;

                for (int curMod = 1; curMod <= Math.Min(Col, inputRows - 1); curMod++)
                {
                    if (matrix[0 + curMod][Col - curMod] ==
                        matrix[0 + (curMod - 1)][Col - (curMod - 1)])
                    {
                        currLen++;
                    }
                }

                maxLen = maxLen < currLen ? currLen : maxLen;
            }

            for (int Row = 1; Row < inputRows; Row++)
            {
                currLen = 1;

                for (int curMod = 1; curMod <= Math.Min(inputRows - 1 - Row - 1, inputCols - 2); curMod++)
                {
                    if (matrix[Row + curMod][(inputCols - 1) - curMod] ==
                        matrix[Row + (curMod + 1)][(inputCols - 1) - (curMod + 1)])
                    {
                        currLen++;
                    }
                }

                maxLen = maxLen < currLen ? currLen : maxLen;
            }

            // right diagonal check
            for (int Row = inputRows - 2; Row >= 0; Row--)
            {
                currLen = 1;

                for (int curMod = 1; curMod <= Math.Min(inputRows - Row - 1, inputCols - 1); curMod++)
                {
                    if (matrix[Row + curMod][0 + curMod] ==
                        matrix[Row + (curMod - 1)][0 + (curMod - 1)])
                    {
                        currLen++;
                    }
                }

                maxLen = maxLen < currLen ? currLen : maxLen;
            }

            // Top Right
            for (int Row = 1; Row < inputRows - 1; Row++)
            {
                currLen = 1;

                for (int curMod = 1; curMod <= Math.Min(Row - 1, inputCols - 1); curMod++)
                {
                    if (matrix[Row - curMod][(inputCols - 1) - curMod] ==
                        matrix[Row - (curMod - 1)][(inputCols - 1) - (curMod - 1)])
                    {
                        currLen++;
                    }
                }

                maxLen = maxLen < currLen ? currLen : maxLen;
            }

            // print maxLen
            Console.WriteLine(maxLen);
        }
    }
}
