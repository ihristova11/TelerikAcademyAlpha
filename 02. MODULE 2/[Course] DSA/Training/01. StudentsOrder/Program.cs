using System;
using System.Linq;

namespace _01.StudentsOrder
{
    public class StudentsOrder
    {
        static void Main()
        {
            var line = Console.ReadLine().Split(' ').ToArray();

            int studentsCount = int.Parse(line[0]);
            int countOfSeatChanges = int.Parse(line[1]);

            var names = Console.ReadLine().Split(' ').ToArray();

            LinkedList<string> linkedList = new LinkedList<string>();

            foreach (var name in names)
            {
                linkedList.AddLast(name);
            }

            for (int i = 0; i < countOfSeatChanges; i++)
            {
                var lineS = Console.ReadLine().Split(' ').ToArray();
                var first = lineS[0];
                var second = lineS[1];
                var firstNode = linkedList.Find(first);
                var secondNode = linkedList.Find(second);

                //linkedList.DeleteNode(firstNode);
                //linkedList.AddBefore(secondNode, first);

                if (firstNode.Previous == null && secondNode.Next == null)
                {
                    secondNode.Previous.Next = firstNode; // zakacham predishniq na second s first
                    firstNode.Previous = secondNode.Previous;

                    secondNode.Previous = firstNode; // zakacham first i second
                    firstNode.Next = secondNode;

                    //linkedList.DeleteNode(firstNode);
                    //linkedList.AddBefore(secondNode, first);
                }

                else if (secondNode.Previous == null && firstNode.Next == null) // second 0 0 0 0 first
                {
                    firstNode.Previous.Next = null; // razkacham first

                    firstNode.Previous = null;
                    firstNode.Next = secondNode;
                    secondNode.Previous = firstNode;

                    //linkedList.DeleteNode(firstNode);
                    //linkedList.AddFirst(first);
                }
                else if (secondNode.Previous == null) // second 0 0 0 first 0 0
                {
                    firstNode.Next.Previous = firstNode.Previous; // razkacham first
                    firstNode.Previous.Next = firstNode.Next;

                    firstNode.Previous = null;
                    firstNode.Next = secondNode;
                    secondNode.Previous = firstNode;

                    //linkedList.DeleteNode(firstNode);
                    //linkedList.AddFirst(first);
                }
                else if (firstNode.Next == null) //  0 0 second 0 0 first
                {
                    firstNode.Previous.Next = null; // razkacham first

                    secondNode.Previous.Next = firstNode;
                    firstNode.Previous = secondNode.Previous;

                    secondNode.Previous = firstNode;
                    firstNode.Next = secondNode;

                    //linkedList.DeleteNode(firstNode);
                    //linkedList.AddBefore(secondNode, first);
                }
                else if (secondNode.Next == null) // 0 0 first 0 0 second
                {
                    firstNode.Next.Previous = firstNode.Previous; // razkacham first
                    firstNode.Previous.Next = firstNode.Next;

                    secondNode.Previous.Next = firstNode;
                    firstNode.Previous = secondNode.Previous;

                    secondNode.Previous = firstNode;
                    firstNode.Next = secondNode;

                    //linkedList.DeleteNode(firstNode);
                    //linkedList.AddBefore(secondNode, first);
                }
                else if (secondNode.Previous == firstNode)
                {
                    continue;
                }
                else if (secondNode.Next == firstNode)
                {
                    linkedList.DeleteNode(secondNode.Next);
                    linkedList.AddBefore(secondNode, first);
                }
                else //  0 0 first 0 0 second 0 0 | 0 0 second 0 0 first 0 0
                {
                    firstNode.Previous.Next = firstNode.Next; // razkacham first
                    firstNode.Next.Previous = firstNode.Previous;

                    secondNode.Previous.Next = firstNode;
                    firstNode.Previous = secondNode.Previous;

                    firstNode.Next = secondNode;
                    secondNode.Previous = firstNode;

                    //linkedList.DeleteNode(firstNode);
                    //linkedList.AddBefore(secondNode, first);
                }


                //Console.Write("------");
                //linkedList.Print();
            }


            var curr = linkedList.First;
            for (int k = 0; k < linkedList.Count - 1; k++)
            {
                Console.Write("{0} ", curr.Value);
                curr = curr.Next;
            }

            Console.Write(curr.Value);
            Console.WriteLine();
        }
    }

    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode<T> Previous { get; set; }

        public LinkedList<T> List { get; set; }
    }

    public class LinkedList<T>
    {
        public LinkedListNode<T> First { get; private set; }

        public LinkedListNode<T> Last { get; private set; }

        public int Count { get; private set; }

        public LinkedListNode<T> AddFirst(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            this.AddFirst(node);
            return node;
        }

        public void AddFirst(LinkedListNode<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("Грешка: Елементът не може да бъде null!");
            }

            if (this.First == null)
            {
                this.First = node;
                this.Last = node;
            }
            else
            {
                node.Next = this.First;
                this.First.Previous = node;
                this.First = node;
            }

            node.List = this;
            this.Count++;
        }

        public LinkedListNode<T> AddLast(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            this.AddLast(node);
            return node;
        }

        public void AddLast(LinkedListNode<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("Грешка: Елементът не може да бъде null!");
            }

            if (this.Last == null)
            {
                this.First = node;
                this.Last = node;
            }
            else
            {
                node.Previous = this.Last;
                this.Last.Next = node;
                this.Last = node;
            }

            node.List = this;
            this.Count++;
        }

        public LinkedListNode<T> AddAfter(LinkedListNode<T> afterNode, T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            this.AddAfter(afterNode, node);
            return node;
        }

        public void AddAfter(LinkedListNode<T> afterNode, LinkedListNode<T> node)
        {
            if (afterNode == null)
            {
                throw new ArgumentNullException("Грешка: Елементът не може да бъде null!");
            }

            if (afterNode.List != this)
            {
                throw new InvalidOperationException("Грешка: Елементът не е в списъка!");
            }

            if (afterNode.Next == null)
            {
                this.AddLast(node);
                return;
            }

            afterNode.Next.Previous = node;
            node.Next = afterNode.Next;
            node.Previous = afterNode;
            afterNode.Next = node;

            node.List = this;
            this.Count++;
        }

        public LinkedListNode<T> AddBefore(LinkedListNode<T> beforeNode, T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            this.AddBefore(beforeNode, node);
            return node;
        }

        public void AddBefore(LinkedListNode<T> beforeNode, LinkedListNode<T> node)
        {
            if (beforeNode == null)
            {
                throw new ArgumentNullException("Грешка: Елементът не може да бъде null!");
            }

            if (beforeNode.List != this)
            {
                throw new InvalidOperationException("Грешка: Елементът не е в списъка!");
            }

            if (beforeNode.Previous == null)
            {
                this.AddFirst(node);
                return;
            }

            beforeNode.Previous.Next = node;
            node.Previous = beforeNode.Previous;
            node.Next = beforeNode;
            beforeNode.Previous = node;

            node.List = this;
            this.Count++;
        }

        public void DeleteNode(LinkedListNode<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("Грешка: Елементът не може да бъде null!");
            }

            if (node.List != this)
            {
                throw new InvalidOperationException("Грешка: Елементът не е в списъка!");
            }

            if (node.Previous != null && node.Next != null)
            {
                node.Previous.Next = node.Next;
                node.Next.Previous = node.Previous;
                node.Previous = null;
                node.Next = null;
            }
            else if (node.Previous == null)
            {
                this.First = this.First.Next;
            }
            else if (node.Next == null)
            {
                this.Last = this.Last.Previous;
            }

            node.List = null;
            this.Count--;
        }

        public void DeleteNode(T value)
        {
            LinkedListNode<T> node = this.Find(value);

            if (node == null)
            {
                throw new InvalidOperationException("Грешка: Не е намерен елемент за изтриване!");
            }

            if (node != null)
            {
                this.DeleteNode(node);
            }
        }

        public LinkedListNode<T> Find(T value)
        {
            if (this.First == null)
            {
                return null;
            }

            LinkedListNode<T> node = this.First;

            if (node.Value.Equals(value))
            {
                return node;
            }

            while (node.Next != null)
            {
                node = node.Next;
                if (node.Value.Equals(value))
                {
                    return node;
                }
            }

            return null;
        }

        public void Clear()
        {
            this.First = null;
            this.Last = null;
            this.Count = 0;
        }

        public void Print()
        {
            LinkedListNode<T> current = this.First;

            while (current != null)
            {
                Console.Write("{0} ", current.Value);
                current = current.Next;
            }

            Console.WriteLine();
        }
    }
}

