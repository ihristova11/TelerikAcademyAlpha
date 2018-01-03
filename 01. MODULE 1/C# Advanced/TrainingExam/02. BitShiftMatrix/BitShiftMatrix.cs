namespace _02.BitShiftMatrix
{
    using System;
    using System.Linq;
    using System.Numerics;

    class BitShiftMatrix
    {
        static int r;
        static int c;

        static void Main()
        {
            BigInteger outputSum = 0;

            r = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            var matrix = new BigInteger[r, c];

            FillTheMatrix(matrix);

            // coeff
            var COEF = r >= c ?
                       r : c;

            //moves number
            var moves = int.Parse(Console.ReadLine());

            var codes = Console.ReadLine()
                .Trim()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var curRow = r - 1;
            var curCol = 0;

            foreach (var code in codes)
            {
                var targetRow = code / COEF;
                var targetCol = code % COEF;

                // move cols first
                for (int move = Math.Min(curCol, targetCol);
                         move <= Math.Max(curCol, targetCol);
                         move++)
                {
                    outputSum += matrix[curRow, move];
                    matrix[curRow, move] = 0;
                }

                curCol = targetCol;

                // move rows second
                for (int move = Math.Min(curRow, targetRow);
                         move <= Math.Max(curRow, targetRow);
                         move++)
                {
                    outputSum += matrix[move, curCol];
                    matrix[move, curCol] = 0;
                }

                curRow = targetRow;
            }

            Console.WriteLine(outputSum);
        }

        //method for filling the matrix
        static void FillTheMatrix(BigInteger[,] matrix)
        {
            var curFill = (BigInteger)1;
            for (int curCol = 0;
                     curCol < matrix.GetLength(1);
                     curCol++)
            {
                matrix[r - 1, curCol] = curFill;
                curFill <<= 1;
            }

            for (int curCol = 0;
                     curCol < c;
                     curCol++)
            {
                curFill = matrix[r - 1, curCol];
                curFill <<= 1;

                for (int curRow = r - 2;
                         curRow >= 0;
                         curRow--)
                {
                    matrix[curRow, curCol] = curFill;
                    curFill <<= 1;
                }
            }
        }
    }
}
