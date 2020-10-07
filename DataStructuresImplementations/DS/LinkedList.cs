using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    class LinkedList<T> : IIterable<T>
    {
        public IIterator<T> GetIterator()
        {
            throw new NotImplementedException();
        }
    }
}
