using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T> where T : IComparable<T>
    {
        public class Node
        {
            public Node next;
            public T value;
            public Node(T value)
            {
                this.value = value;
            }

        }
        private int size;
        private Node head;
        private Node tail;

        public LinkedList()
        {
            this.size = 0;
            this.head = null;
        }
        public int Count => this.size;

        public void Add(T item)
        {
            this.size++;

            var node = new Node(item);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.next = node;
            }
            tail = node;

        }

        public void AddAfter(T item)
        {
            this.size++;

            var node = new Node(item);
        }

        public Node Find(T value)
        {
            Node tempNode = head;

            while (tempNode != null)
            {
                if (value.Equals(tempNode.value))
                {
                    return tempNode;
                }
                tempNode = tempNode.next;
            }
            throw new ArgumentException();
        }
        public void ListNodes()
        {
            Node tempNode = head;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.value);
                tempNode = tempNode.next;
            }
        }

        public bool Remove(T value)
        {
            Node tempPrev = null;
            Node tempNode = head;

            while (tempNode != null)
            {
                if (value.Equals(tempNode.value))
                {
                    this.size--;
                    if (tempPrev == null)
                    {
                        head = tempNode.next;
                        return true;
                    }
                    else
                    {
                        tempPrev.next = tempNode.next;
                        tempNode.next = null;
                        return true;
                    }

                }
                tempPrev = tempNode;
                tempNode = tempNode.next;
            }
            throw new ArgumentException();
        }
    }
}