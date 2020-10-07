using System;

namespace DS
{
    class Program
    {
        static void Main(string[] args)
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
