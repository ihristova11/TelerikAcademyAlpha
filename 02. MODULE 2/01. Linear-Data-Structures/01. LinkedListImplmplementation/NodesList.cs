using System;

namespace _01.LinkedListImplmplementation
{
    public class NodesList<T>
    {
        // not fully implemented

        public ListNode<T> Head { get; set; }

        public ListNode<T> Tail { get; set; }

        public int Count { get; set; }

        public void AddBefore(ListNode<T> node, ListNode<T> newNode)
        {
            newNode.Next = node;
            newNode.Prev = node.Prev;
            newNode.Prev.Next = newNode;
            node.Prev = newNode;

            this.Count++;
        }

        public void AddAfter(ListNode<T> newNode, ListNode<T> node)
        {
            newNode.Prev = node;
            newNode.Next = node.Next;
            newNode.Next.Prev = newNode;
            node.Next = newNode;

            this.Count++;
        }

        public void AddFirst(ListNode<T> node)
        {
            if (this.Head == null)
            {
                throw new ArgumentException("there is no first element");
            }

            AddBefore(this.Head, node);
            this.Head = node;
        }

        public void AddLast(ListNode<T> node)
        {
            if (this.Head == null)
            {
                throw new ArgumentException("there is no first element");
            }

            AddBefore(this.Head, node);
        }

        public void Remove(ListNode<T> nodeToRemove)
        {
            if (nodeToRemove.Next != nodeToRemove)
            {
                nodeToRemove.Next.Prev = nodeToRemove.Prev;
                nodeToRemove.Prev.Next = nodeToRemove.Next;
                if (this.Head == nodeToRemove)
                {
                    this.Head = nodeToRemove.Next;
                }
            }
            else
            {
                this.Head = null;
            }

            this.Count--;
        }

        public void RemoveFirst()
        {
            if (this.Head == null)
            {
                throw new ArgumentException("there is no first element");
            }

            Remove(this.Head);
        }

        
    }
}
