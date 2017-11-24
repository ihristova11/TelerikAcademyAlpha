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

        static void Main()
        {

        }

        public static void FillTheMatrix()
        {
            int[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
        }
    }
}
