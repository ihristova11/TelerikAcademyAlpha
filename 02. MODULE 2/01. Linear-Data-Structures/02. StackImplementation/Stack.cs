using System;

namespace _02.StackImplementation
{
    public class Stack<T>
    {
        private T[] s;
        private int currentStackIndex;

        public Stack(int N)
        {
            if (N < 0)
                throw new ArgumentOutOfRangeException("N");

            s = new T[N];
            currentStackIndex = 0;
        }

        public void Push(T x)
        {
            if (currentStackIndex + 1 >= s.Length)
            {
                //Notice the + 1, to counter the 0 length problem
                Array.Resize(ref s, (s.Length + 1) * 2);
            }

            s[currentStackIndex++] = x;
        }

        public T Pop()
        {
            if (currentStackIndex == 0)
                throw new InvalidOperationException("The stack is empty");

            T value = s[--currentStackIndex];
            s[currentStackIndex] = default(T);
            return value;
        }
    }
}
