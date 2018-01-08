using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusOneMultiplyOne
{
    public class PlusOneMultiplyOne
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(uint.Parse).ToArray();
            uint n = input[0];
            uint m = input[1];

            FindMember(n, m);
           //Console.WriteLine(FindMember(n, m));
        }

        private static void FindMember(uint n, uint m, uint member = 0)
        {
            uint result;
            if (m == 1)
            {
                result =  n;
            }
            else
            {
                var elements = new LinkedList<uint>();

                while (member < m)
                {
                    elements.AddLast(n + 1);
                    elements.AddLast(2 * n + 1);
                    elements.AddLast(n + 2);

                    member += 3;
                    n = elements.First.Value;
                    elements.RemoveFirst();
                }
                while (m <= member)
                {
                    elements.RemoveLast();
                    member--;
                }

                result = elements.Last.Value;
            }

            Console.WriteLine(result);
        }
    }
}
