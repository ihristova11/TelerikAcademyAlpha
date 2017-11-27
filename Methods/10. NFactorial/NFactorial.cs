namespace _10.NFactorial
{
    using System;
    using System.Linq;
    using System.Numerics;

    class NFactorial
    {
        static void Main()
        {
            int[] numberArr = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int number = int.Parse(string.Join("", numberArr));            
            
            Console.WriteLine(CalculateProduct(number));
        }

        public static BigInteger CalculateProduct(int number)
        {
            BigInteger result = 1;
            for (int i = number; i > 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}