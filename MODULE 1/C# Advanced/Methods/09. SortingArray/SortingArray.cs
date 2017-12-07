namespace _09.SortingArray
{
    using System;
    using System.Linq;

    class SortingArray
    {
        static void Main()
        {
            int len = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Sort(numbers);
        }

        public static void Sort(int[] numbers)
        {
            int temp = 0;

            for (int write = 0; write < numbers.Length; write++)
            {
                for (int sort = 0; sort < numbers.Length - 1; sort++)
                {
                    if (numbers[sort] > numbers[sort + 1])
                    {
                        temp = numbers[sort + 1];
                        numbers[sort + 1] = numbers[sort];
                        numbers[sort] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
