namespace _01.LinkedListImplmplementation
{
    public class ListNode<T>
    {
        public ListNode(T value)
        {
            this.Value = value;
        }
        
        public T Value { get; set; }

        public ListNode<T> Next { get; set; }

        public ListNode<T> Prev { get; set; }
    }
}
