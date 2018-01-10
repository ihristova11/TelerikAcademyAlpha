using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _06.RemoveOddOccurrences
{
    class RemoveOddOccurrences
    {
        static void Main()
        {
            //todo: fix!!!
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var occur = new Queue<int>();
            var numbers = new Queue<int>();

            list.Sort();
            Console.WriteLine(string.Join(" ", list));
            int counter = 1;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1] == list[i])
                {
                    counter++;
                }
                else
                {
                    numbers.Enqueue(i);
                    occur.Enqueue(counter);
                    counter = 1;
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"{numbers.Dequeue()} - {occur.Dequeue()}");
            }
        }
    }
}
