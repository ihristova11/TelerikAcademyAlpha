using System;
using System.Collections.Generic;
using System.Linq;

namespace Swappings
{
    public static class Swappings
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int[] swappings = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddFirst(1);

            var currValue = numbers.First;

            for (int i = 2; i <= numbersCount; i++)
            {
                numbers.AddAfter(currValue, new LinkedListNode<int>(i));
                currValue = currValue.Next;
            }

            int desiredValue;
            currValue = numbers.First;

            for (int i = 0; i < swappings.Length; i++)
            {
                desiredValue = swappings[i];

                while (currValue != null && currValue.Value != desiredValue)
                {
                    currValue = currValue.Next;
                }
                
                currValue.Next.SwapWith(numbers.First);
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        public static void SwapWith<T>(this LinkedListNode<T> first, LinkedListNode<T> second)
        {
            if (first == null)
                throw new ArgumentNullException("first");

            if (second == null)
                throw new ArgumentNullException("second");

            var tmp = first.Value;
            first.Value = second.Value;
            second.Value = tmp;
        }
    }
}
