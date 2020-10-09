using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public interface IQueue<T> : IIterable<T>
    {
        void Enqueue(T value);
        T Dequeue();
        bool TryDequeue(out T ReturnValue);
        T Peek();
        bool TryPeek(out T ReturnValue);
        bool IsEmpty();
    }
}
