namespace _05.LargerThanNeighbours
{
    using System;
    using System.Linq;

    class LargerThanNeightbours
    {
        static void Main()
        {
            Console.WriteLine(CheckNumberIfLarger());
        }

        public static int CheckNumberIfLarger()
        {
            int largerNumbers = 0;
            int len = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int[] numbers = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 1; i < len - 1; i++)
            {
                //largerNumbers = (numbers[i - 1] < numbers[i] && numbers[i] > numbers[i + 1]) ? largerNumbers++ : largerNumbers;
                if(numbers[i - 1] < numbers[i] && numbers[i] > numbers[i + 1])
                {
                    largerNumbers++;
                }
            }

            return largerNumbers;
        }
    }
}
