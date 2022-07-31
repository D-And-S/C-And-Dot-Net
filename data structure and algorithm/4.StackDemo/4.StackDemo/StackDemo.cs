using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.StackDemo
{
    internal class StackDemo
    {
        //create push, pop, peek, isEmpty by using regular int[]
        private int[] _items = new int[5];
        private int _count;

        public void Push(int item){
            _items[_count] = item;
            _count++;
        }

        public int Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException();
            return _items[--_count];
        }
        
        public bool IsEmpty()
        {
            return _items.Length == 0;
        }

        // return the item of the top of stack without removing it 
        public int Peek()
        {
            if(IsEmpty()) throw new InvalidOperationException();
            return _items[_count - 1];
        }
        public void Print()
        {
            for (var i = 0; i < _count; i++)
            {
                Console.WriteLine(_items[i]);
            }
        }

    }
}
