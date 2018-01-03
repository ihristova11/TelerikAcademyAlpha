namespace GenericClass
{
    using System;
    using System.Linq;
    using System.Text;

    public class GenericList<T>
        where T : IComparable
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
            if (lastIndex + 1 == this.list.Length)
            {
                DoubleSize();
            }

            this.list[++lastIndex] = element;
        }

        public T Max()
        {
            T max = default(T);

            if (list.Length > 0)
            {
                max = this.list[0];
                foreach (var element in this.list)
                {
                    if (max.CompareTo(element) < 0)
                    {
                        max = element;
                    }
                }
            }
            return max;
        }

        public T Min()
        {
            T min = default(T);

            if (this.list.Length > 0)
            {
                min = this.list[0];

                foreach (var element in this.list)
                {
                    if (min.CompareTo(element) > 0)
                    {
                        min = element;
                    }
                }
            }
            return min;
        }

        public T this[int index]
        {
            get
            {
                CheckRange(index);
                return this.list[index];
            }
            set
            {
                CheckRange(index);
                this.list[index] = value;
            }
        }

        public void InsertAt(int index, T element)
        {
            CheckRange(index);

            if (this.lastIndex + 1 == index)
            {
                DoubleSize();
            }

            for (int ind = this.lastIndex + 1; ind > index; ind--)
            {
                this.list[ind] = this.list[ind - 1];
            }
            this.list[index] = element;
            ++lastIndex;
        }

        public int IndexOf(T element)
        {
            int index = -1;

            for (int i = 0; i < this.lastIndex; i++)
            {
                if(element.Equals(this.list[i]))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public void Clear()
        {
            for (int ind = 0; ind < this.lastIndex; ind++)
            {
                this.list[ind] = default(T);
            }
            this.lastIndex = -1;
        }

        public void RemoveAt(int index)
        {
            CheckRange(index);

            for (int ind = index + 1; ind <= this.lastIndex; ind++)
            {
                this.list[ind - 1] = this.list[ind];
            }

            this.list[this.lastIndex--] = default(T);
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

        private void CheckRange(int index)
        {
            if (index < 0 || index > this.lastIndex)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int ind = 0; ind <= this.lastIndex; ind++)
            {
                result.AppendLine(String.Format("{0,-5}{1}", String.Format("[{0}]", ind), this.list[ind]));
            }

            return result.ToString().Trim();
        }
    }
}
