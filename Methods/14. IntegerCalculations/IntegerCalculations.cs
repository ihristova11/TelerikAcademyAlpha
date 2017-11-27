namespace _14.IntegerCalculations
{
    using System;
    using System.Linq;

    class IntegerCalculations
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(FindMinimum(numbers));
            Console.WriteLine(FindMaximum(numbers));
            Console.WriteLine(FindAverage(numbers));
            Console.WriteLine(FindSum(numbers));
            Console.WriteLine(FindProduct(numbers));
        }

        public static int FindMinimum(int[] numbers)
        {
            int minNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                minNumber = numbers[i] < minNumber ? numbers[i] : minNumber;
            }

            return minNumber;
        }

        public static int FindMaximum(int[] numbers)
        {
            int maxNumber = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                maxNumber = numbers[i] > maxNumber ? numbers[i] : maxNumber;
            }

            return maxNumber;
        }

        public static string FindAverage(int[] numbers)
        {
            return (FindSum(numbers) / 5.0).ToString("F2");
        }

        public static int FindSum(int[] numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static long FindProduct(int[] numbers)
        {
            long product = 1;
            foreach (var number in numbers)
            {
                product *= number;
            }

            return product;
        }
    }
}

