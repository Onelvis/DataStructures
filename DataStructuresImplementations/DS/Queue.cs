using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class Queue<T> : IIterable<T>
    {
        public IIterator<T> GetIterator()
        {
            throw new NotImplementedException();
        }
    }
}
