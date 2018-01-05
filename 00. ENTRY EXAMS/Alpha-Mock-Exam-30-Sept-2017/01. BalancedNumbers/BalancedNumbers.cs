using System;

namespace _01.BalancedNumbers
{
    class BalancedNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            Sum(number, sum);

        }

        public static int Sum(int number, int sum)
        {
            
            int a = number / 100;
            int b = number / 10 % 10;
            int c = number % 10;

            if (a + c == b)
            {
                sum += number;
                return Sum(int.Parse(Console.ReadLine()), sum);
            }
            else
            {
                Console.WriteLine(sum);
                return sum;
            }
        }
    }
}
