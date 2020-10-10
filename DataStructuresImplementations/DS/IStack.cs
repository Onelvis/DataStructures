using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    interface IStack<T> : IIterable<T>
    {
        void Push(T value);
        T Pop();
    }
}
