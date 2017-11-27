namespace _04.AppearanceCount
{
    using System;
    using System.Linq;

    class AppearanceCount
    {
        static void Main()
        {
            Console.WriteLine(CountAppearances());
        }

        public static int CountAppearances()
        {
            int times = 0;
            int len = int.Parse(Console.ReadLine());
            string inputArr = Console.ReadLine();
            int searchedNum = int.Parse(Console.ReadLine());
            int[] numbers = inputArr.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray().ToArray();
            foreach (var number in numbers)
            {
                if (number == searchedNum) times++;
            }
            return times;
        }
    }
}
