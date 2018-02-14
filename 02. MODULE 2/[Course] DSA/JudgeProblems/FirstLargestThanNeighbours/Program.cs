namespace _06.FirstLargerThanNeighbours
{
    using System;
    using System.Linq;

    class FirstLargerThanNeighbours
    {
        static void Main()
        {
            Console.WriteLine(FindFirstLarger());
        }

        public static int FindFirstLarger()
        {
            int len = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int[] numbers = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 1; i < len - 1; i++)
            {
                if (numbers[i - 1] < numbers[i] && numbers[i] > numbers[i + 1])
                {
                    return i;
                    break;
                }

            }
            return -1;
        }
    }
}