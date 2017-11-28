namespace _04.BishopPathFinder
{
    using System;
    using System.Linq;

    class BishopPathFinder
    {
        public static int eaten = 0;
        public static int[,] matrix;
        public static int row;
        public static int col;
        public static int[] rows = { -1, -1, 1, 1 };
        public static int[] cols = { -1, 1, 1, -1 };
        static void Main()
        {
            FillTheMatrix();
            Print();
        }

        public static int GetMoveDirection(string dir)
        {
            switch(dir)
            {
                case "LU": return 0;
                case "UL": return 0;
                case "RU": return 1;
                case "UR": return 1;
                case "DR": return 2;
                case "RD": return 2;
                case "DL": return 3;
                case "LD": return 3;

            }
        }

        // method for filling the matrix
        public static void FillTheMatrix()
        {
            int[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            row = input[0];
            col = input[1];
            matrix = new int[row, col];
            matrix[row - 1, 0] = 0;
            int num = 0;

            for (int i = row - 1; i >= 0; i--)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = (row - 1 - i) * 3 + j * 3;
                }
            }
            int movesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < movesCount; i++)
            {
                var directions = Console.ReadLine().Split(' ');
                var dir = directions[0];
                var moves = directions[1];
                Console.WriteLine(dir + " " + moves);
            }

        }

        // method for printing the matrix
        public static void Print()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

