namespace _05.RemoveNegativeInSequence
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

    public class RemoveNegativeInSequence
    {
        static void Main()
        {
        }
    }
}
