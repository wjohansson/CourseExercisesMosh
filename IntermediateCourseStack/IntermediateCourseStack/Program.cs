using System;

namespace IntermediateCourseStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Pop();
            stack.Pop();

            stack.Clear();

            stack.Push(4);
        }
    }
}
