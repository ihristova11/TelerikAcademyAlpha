using System;

namespace Fibonacci
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Fibonacci(0, 1, 1, number);
            Console.WriteLine();
        }

        public static void Fibonacci(int a, int b, int counter, int number)
        {
            Console.Write(a + " ");
            if (counter < number) Fibonacci(b, a + b, counter + 1, number);
        }
    }
}
