using System;

namespace DS
{
    public class Stack<T> : IStack<T>
    {
        private int Size { get; set; }
        private T[] Values { get; set; }
        private int Top { get; set; }

        public IIterator<T> GetIterator()
        {
            return new StackIterator<T>(Values, Top);
        }

        public Stack(int stackSize)
        {
            Size = stackSize;
            Values = new T[Size];
            Top = -1;
        }

        public Stack()
        {
            Size = 16;
            Values = new T[Size];
            Top = -1;
        }

        public void Push(T value)
        {
            Top++;
            if (Top > Size)
            {
                T[] newArray = new T[Values.Length + 50];
                Values.CopyTo(newArray, 0);
                Values = newArray;
            }

            Values[Top] = value;
        }

        public T Pop()
        {
            if (Top > -1)
            {
                T value = Values[Top];
                Values[Top--] = default(T);
                return value;
            }
            else
            {
                Console.WriteLine("The stack is so empty...");
                return default;
            }
        }


        private class StackIterator<T2> : IIterator<T2>
        {
            private T2[] Values;

            private int Top { get; set; }

            private int Index = 0;

            public StackIterator(T2[] Values, int Top)
            {
                this.Values = Values;
                this.Top = Top;
            }

            public T2 GetNext()
            {
                return Values[Index++];
            }

            public bool HasMore()
            {
                if (Index > Top)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }

}
