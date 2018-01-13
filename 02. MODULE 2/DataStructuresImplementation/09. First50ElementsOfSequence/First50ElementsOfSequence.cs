using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;

namespace _09.First50ElementsOfSequence
{
    public class First50ElementsOfSequence
    {
        static void Main()
        {
            int n = 2;

            Console.WriteLine(string.Join(" ", AddToSequence(2, 50)));
        }

        public static IList<int> AddToSequence(int n, int sequenceLen)
        {
            Queue<int> sequence = new Queue<int>();
            List<int> elements = new List<int>();
            int counter = 0;

            if (sequence.Count == 0)
            {
                sequence.Enqueue(n);
            }

            

            while (counter < sequenceLen)
            {
                int element = sequence.Dequeue();
                elements.Add(element);

                sequence.Enqueue(element + 1);
                sequence.Enqueue(2 * element + 1);
                sequence.Enqueue(element + 2);

                counter += 3;
            }

            while (sequence.Count != 0)
            {
                elements.Add(sequence.Dequeue());
            }

            return elements;
        }
    }
}
