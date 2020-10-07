using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public interface IQueue<T> : IIterable<T>
    {
        void Enqueue(T value);
        T Dequeue();
        T Peek();
    }
}
