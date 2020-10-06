using System;
namespace DS
{
    public class StackIterator<T> : IIterator<T>
    {
        T[] stack;

        int index = 0;

        public StackIterator(Stack<T> recievedStack)
        {
            stack = recievedStack.values;
        }
        public T GetNext()
        {
            return stack[index++];
        }

        public bool HasMore()
        {
            if (index > stack.Length - 1)
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
