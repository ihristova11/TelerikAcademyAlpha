namespace _01.LinkedListImplmplementation
{
    public class NodesList<T>
    {

        public ListNode<T> Head { get; set; }

        public ListNode<T> First { get; set; }

        public ListNode<T> Last { get; set; }

        public int Count { get; set; }

        public void AddBefore(ListNode<T> node, ListNode<T> newNode)
        {
            newNode.Next = node;
            newNode.Prev = node.Prev;
            newNode.Prev.Next = newNode;
            node.Prev = newNode;

            this.Count++;
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
    }
}
