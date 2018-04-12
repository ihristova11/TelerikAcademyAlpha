using System;

namespace FibonacciSum
{
    public class FibonacciSum
    {
        static void Main()
        {
            Console.WriteLine(Fibonacci(6));
        }

        private static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
