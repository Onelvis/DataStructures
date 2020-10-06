using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public interface IIterator<T>
    {
        T GetNext();
        bool HasMore();
    }
}
