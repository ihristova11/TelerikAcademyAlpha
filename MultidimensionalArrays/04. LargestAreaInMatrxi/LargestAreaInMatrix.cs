namespace _04.LargestAreaInMatrxi
{
    using System;
    using System.Linq;
    class LargestAreaInMatrix
    {
        public static int rows;
        public static int cols;
        public static int[][] array;
        static void Main()
        {
            // reading the input
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
    }
}
