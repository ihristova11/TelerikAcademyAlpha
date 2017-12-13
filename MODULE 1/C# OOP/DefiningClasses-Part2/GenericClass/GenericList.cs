namespace GenericClass
{
    public class GenericList<T>
    {
        private T[] list;
        private int lastIndex;

        public GenericList(int capacity)
        {
            this.list = new T[capacity];
            this.lastIndex = -1;
        }

        public void Add(T element)
        {
            if(lastIndex + 1 == this.list.Length)
            {
                DoubleSize();
            }

            this.list[++lastIndex] = element;
        }

        private void DoubleSize()
        {
            int newSize = this.list.Length == 0 ? 2 : this.list.Length * 2;

            T[] newList = new T[newSize];
            for (int i = 0; i <= this.lastIndex; i++)
            {
                newList[i] = this.list[i];
            }

            this.list = newList;
        }
    }
}
