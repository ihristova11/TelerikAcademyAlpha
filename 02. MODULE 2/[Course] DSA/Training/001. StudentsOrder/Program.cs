using System;
using System.Collections.Generic;
using System.Linq;

namespace _001.StudentsOrder
{
    public class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToArray();
            var studentsCount = int.Parse(numbers[0]);
            var countOfChanges = int.Parse(numbers[1]);

            var names = Console.ReadLine().Split(' ').ToArray();

            var list = new LinkedList<string>();
            var nodes = new Dictionary<string, LinkedListNode<string>>();


            for (int i = 0; i < studentsCount; i++)
            {
                var node = new LinkedListNode<string>(names[i]);
                list.AddLast(node);
                nodes.Add(names[i], node);
            }


            for (int i = 0; i < countOfChanges; i++)
            {
                var line = Console.ReadLine().Split(' ').ToArray();
                string a = line[0];
                string b = line[1];

                var nodeA = nodes[a];
                var nodeB = nodes[b];

                list.Remove(nodeA);
                var newNodeA = new LinkedListNode<string>(a);
                list.AddBefore(nodeB, newNodeA);
                nodes.Remove(a);
                nodes.Add(a, newNodeA);
            }

            var curr = list.First;
            for (int i = 0; i < studentsCount - 1; i++)
            {
                Console.Write("{0} ", curr.Value);
                curr = curr.Next;
            }

            Console.Write(curr.Value);
            Console.WriteLine();
        }
    }
}