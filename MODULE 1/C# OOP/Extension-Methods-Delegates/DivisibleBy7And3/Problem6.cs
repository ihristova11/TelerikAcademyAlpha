namespace DivisibleBy7And3
{
    using System;
    using System.Linq;

    class Problem6
    {
        static void Main()
        {
            var numbers = new int[3];
            numbers[0] = 5;
            numbers[1] = 7;
            numbers[2] = 42;
            FindDivisible(numbers);
        }

        public static void FindDivisible(int[] numbers)
        {
            var divisible = numbers.Where(x => x % 21 == 0);

            foreach (var number in divisible)
            {
                Console.WriteLine(number);
            }
        }
    }
}
