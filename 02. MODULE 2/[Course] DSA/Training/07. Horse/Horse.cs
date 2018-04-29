using System;
using System.Collections.Generic;

namespace _07.Horse
{
    public class Horse
    {
        private static int rows;
        private static int cols;
        private static int rowS;
        private static int colS;
        private static int[] middleCol;

        private const int max = 8;
        private static readonly int[] movesR = { 1, 1, -1, -1, 2, 2, -2, -2 };
        private static readonly int[] movesC = { 2, -2, 2, -2, 1, -1, 1, -1 };
        private static int[,] board;

        static void Main()
        {
            rows = int.Parse(Console.ReadLine());

            cols = int.Parse(Console.ReadLine());

            rowS = int.Parse(Console.ReadLine());

            colS = int.Parse(Console.ReadLine());

            middleCol = new int[rows];
            board = new int[rows, cols];

            Bfs();

            for (int i = 0; i < middleCol.Length; i++)
            {
                Console.WriteLine(middleCol[i]);
            }
        }

        private static void Bfs()
        {
            var queue = new Queue<int[]>();
            queue.Enqueue(new int[] { rowS, colS }); // [0] = row, [1] = col

            board[rowS, colS] = 1;
            int middleColFilledCellsCount = 0;

            while (queue.Count != 0 && middleColFilledCellsCount < rows)
            {
                var cell = queue.Dequeue();

                if (cell[1] == cols / 2)
                {
                    middleColFilledCellsCount++;
                    middleCol[cell[0]] = board[cell[0], cell[1]];
                }

                for (int i = 0; i < max; i++)
                {
                    var newRow = cell[0] + movesR[i];
                    var newCol = cell[1] + movesC[i];

                    if ((newRow >= 0 && newCol >= 0 && newRow < rows && newCol < cols) && board[newRow, newCol] == 0)
                    {
                        board[newRow, newCol] = board[cell[0], cell[1]] + 1;
                        queue.Enqueue(new int[] {newRow, newCol });
                    }
                }
            }
        }
    }
}