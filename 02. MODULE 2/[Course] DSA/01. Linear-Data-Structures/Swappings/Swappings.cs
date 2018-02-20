using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Swappings
{
    public class ListNode
    {
        public ListNode(int value, ListNode prev)
        {
            this.Value = value;
            this.Previous = prev;
            if (prev != null)
            {
                this.Previous.Next = this;
            }
        }

        public int Value { get; set; }

        public ListNode Next { get; set; }

        public ListNode Previous { get; set; }
    }

    public class Swappings
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var dict = new Dictionary<int, ListNode>();

            ListNode head = null;
            ListNode tail = null;
            ListNode prev = null;

            for (int i = 1; i <= n; i++)
            {
                var node = new ListNode(i, prev);
                prev = node;
                if (head == null)
                {
                    head = node;
                }

                tail = node;
                dict.Add(i, node);
            }

            foreach (int node in arr)
            {
                Swap(dict[node], ref head, ref tail);
            }

            var current = head;

            var result = new List<int>(n);

            while (current != null) // adding node values in list
            {
                result.Add(current.Value);
                current = current.Next; // iterating 
            }

            Console.WriteLine(string.Join(" ", result));
        }

        public static void Swap(ListNode node, ref ListNode head, ref ListNode tail)
        {
            var newHead = node.Next ?? node;
            var newTail = node.Previous ?? node;

            if (newTail == node) // if node is the last element => tail element
            {
                node.Next = null;
            }
            else
            {
                node.Next = head;
                head.Previous = node;
            }

            if (newHead == node) // if node is the first element => head element
            {
                node.Previous = null;
            }
            else
            {
                node.Previous = tail;
                tail.Next = node;
            }

            newHead.Previous = null;

            newTail.Next = null;

            head = newHead;
            tail = newTail;
        }
    }
}