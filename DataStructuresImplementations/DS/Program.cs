using System;

namespace DS
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedQueueTest();

        }

        static void LinkedQueueTest()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Dequeue();

            var iterator = queue.GetIterator();

            while (iterator.HasMore())
            {
                Console.WriteLine(iterator.GetNext());
            }
            Console.ReadKey();
        }

        static void StackTest()
        {
            Stack<int> stack = new Stack<int>(6);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            stack.Push(6);
            var iterator = stack.GetIterator();

            while (iterator.HasMore())
            {
                Console.WriteLine(iterator.GetNext());
            }

            Console.ReadKey();
        }
    }
}
