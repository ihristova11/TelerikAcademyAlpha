using System;
using System.Collections.Generic;
using System.Linq;

namespace Swappings
{
    public class Swappings
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int[] swappings = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddFirst(1);

            for (int i = 1; i < numbersCount; i++)
            {
                numbers.AddAfter(new LinkedListNode<int>(i - 1), new LinkedListNode<int>(i));
            }
            var currValue = numbers.First;
            int desiredValue = swappings[0];

            for (int i = 0; i < swappings.Length; i++)
            {
                while (currValue != null && currValue.Value != desiredValue)
                {
                    currValue = currValue.Next;
                }
            }
        }
    }
}
