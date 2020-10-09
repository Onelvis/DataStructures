using System;

namespace DS
{
    public class LinkedQueue<T> : IQueue<T> 
    {
        private Node<T> Rear;

        private Node<T> Front;

        public LinkedQueue() { }

        public void Enqueue(T value)
        {
            if (Front == null)
            {
                Front = new Node<T>(value);
                Rear = Front;
            }
            else
            {
                Rear.Next = new Node<T>(value);
                Rear = Rear.Next;
            }
        }

        public T Dequeue()
        {
            if (Front == null)
            {
                throw new Exception("The Queue is empty");
            }
            else
            {
                var value = Front.Value;
                Front = Front.Next;
                return value;
            }
        }

        public T Peek()
        {
            if(Front == null)
            {
                throw new Exception("The Queue is empty");
            }
            return Front.Value;
        }

        class Node<E>
        {
            public E Value;

            public Node<E> Next;

            public Node(E Value)
            {
                this.Value = Value;
                Next = null;
            }
        }


        public IIterator<T> GetIterator()
        {
            return new LinkedQueueIterator<T>(this.Front);
        }

        public bool IsEmpty()
        {
            return Front == null;
        }

        public bool TryDequeue(out T ReturnValue)
        {
            if (IsEmpty())
            {
                ReturnValue = default;
                return false;
            }
            else
            {
                ReturnValue = Front.Value;
                Front = Front.Next;
                return true;
            }
        }

        public bool TryPeek(out T ReturnValue)
        {
            if (IsEmpty())
            {
                ReturnValue = default;
                return false;
            }
            else
            {
                ReturnValue = Front.Value;
                return true;
            }
        }

        private class LinkedQueueIterator<N> : IIterator<N>
        {
            private Node<N> currentNode;

            public LinkedQueueIterator(Node<N> Front)
            {
                currentNode = Front;
            }

            public N GetNext()
            {
                var value = currentNode.Value;
                currentNode = currentNode.Next;
                return value;
            }

            public bool HasMore()
            {
                return (currentNode != null);
            }
        }

    }
}
