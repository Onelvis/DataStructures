namespace DS
{
    public class StackIterator<T> : IIterator<T>
    {
        private T[] stack;

        private int top { get; set; }

        private int index = 0;

        public StackIterator(T[] values, int top)
        {
            this.stack = values;
            this.top = top;
        }
        public T GetNext()
        {
            return stack[index++];
        }

        public bool HasMore()
        {
            if (index > top)
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
