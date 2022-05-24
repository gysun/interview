using System;

namespace Algorithms
{
    internal static class Program
    {
        private static void Main()
        {
            var stack = new MyStack();

            stack.Push(5);
            stack.Push(2);
            stack.Push(4);
            stack.Push(1);
            stack.Push(9);

            Console.WriteLine(stack.Min()); // should show 1
            Console.WriteLine(stack.Pop()); // should show 9

            Console.WriteLine(stack.Min()); // should show 1
            Console.WriteLine(stack.Pop()); // should show 1

            Console.WriteLine(stack.Min()); // should show 2
            Console.WriteLine(stack.Pop()); // should show 4

            Console.WriteLine(stack.Min()); // should show 2
            Console.WriteLine(stack.Pop()); // should show 2

            Console.WriteLine(stack.Min()); // should show 5
            Console.WriteLine(stack.Pop()); // should show 5

            Console.WriteLine(stack.Min()); // should throw InvalidOperationException
        }
    }
}