using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesDemo
{
    internal class QueueWithTwoStack
    {
        // Queue -> [10,20,30]

        // S1 [10,20,30] // we will pop and store in stack to

        // S2 [30, 20, 10]

        private readonly Stack<int> _stack1 = new Stack<int>();
        private readonly Stack<int> _stack2 = new Stack<int>();

        public void Enqueue(int item)
        {
            _stack1.Push(item);
        }

        public int Dequeue()
        {
            if(_stack2.Count == 0)
            {
                while(_stack1.Count != 0)
                {
                    _stack2.Push(_stack1.Pop());
                }
            }
            return _stack2.Pop();
        }

        public void PrintStack2()
        {
            foreach(var item in _stack2)
            {
                Console.WriteLine("Stack 2: " + item);
            }
        }
    }
}
