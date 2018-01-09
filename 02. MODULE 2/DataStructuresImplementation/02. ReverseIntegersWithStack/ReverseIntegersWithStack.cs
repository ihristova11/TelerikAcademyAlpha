using System;
using System.Collections.Generic;

namespace _02.ReverseIntegersWithStack
{
    public class ReverseIntegersWithStack
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Push(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
