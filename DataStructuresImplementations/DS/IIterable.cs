using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public interface IIterable<T>
    {
        IIterator<T> GetIterator();
    }
}
