using System;

namespace DS
{
    public class Stack<T> : IIterable<T>
    {
        private int size { get; set; }
        private T[] values { get; set; }
        private int top { get; set; }

        public IIterator<T> GetIterator()
        {
            return new StackIterator<T>(values, top);
        }
        public Stack(int stackSize)
        {
            size = stackSize;
            values = new T[size];
            top = -1;
        }
        public Stack()
        {
            values = new T[size];
            top = -1;
        }

        public void Push(T pushed_value)
        {
            top++;
            if (top > size)
            {
                T[] newArray = new T[values.Length + 50];
                values.CopyTo(newArray, 0);
                values = newArray;
            }

            values[top] = pushed_value;
        }

        public T Pop()
        {
            if (top > -1)
            {
                T value = values[top];
                values[top--] = default(T);
                return value;
            }
            else
            {
                Console.WriteLine("The stack is so empty...");
                return default(T);
            }
        }
    }
}
