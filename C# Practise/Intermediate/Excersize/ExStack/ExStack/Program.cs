using System;
using System.Collections;

namespace ExStack
{
    public class Stack
    {
        private readonly ArrayList _arrlist = new ArrayList();
        public void Push(object obj)
        {
            if (obj is null)           
                throw new InvalidOperationException("Object is Null");

            _arrlist.Add(obj);
        }
        public object Pop()
        {
            if (_arrlist.Count ==0)
                throw new InvalidOperationException("Stack is empty");

            var index = _arrlist.Count - 1;

            var lastObject = _arrlist[index];

            _arrlist.RemoveAt(index);

            return lastObject;
        }

        public void Clear()
        {
            _arrlist.Clear();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
