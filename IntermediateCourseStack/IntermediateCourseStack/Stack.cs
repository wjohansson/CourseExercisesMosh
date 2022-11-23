using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourseStack
{
    public class Stack
    {
        private readonly List<object> _stack = new();

        public void Push(object obj)
        {

            if (obj == null)
            {
                throw new InvalidOperationException("Null can't be passed into the object");
            }

            _stack.Add(obj);

            Console.WriteLine("Items in stack:");
            foreach (object item in _stack)
            {
                Console.WriteLine(item);
            }
        }

        public void Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is already empty");
            }
            var poppedItem = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            Console.WriteLine("Item removed from stack: " + poppedItem);
            Console.WriteLine("New stack is:");

            foreach (object item in _stack)
            {
                Console.WriteLine(item);
            }
        }

        public void Clear()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is already empty");
            }
            _stack.Clear();
            Console.WriteLine("Stack was cleared, stack is now empty");
        }

    }
}
