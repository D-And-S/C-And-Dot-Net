using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesDemo
{
    internal class ArrayQueue
    {
        private int[] _items;
        private int _rear;
        private int _front;
        private int _count;
        public ArrayQueue(int size)
        {
            _items = new int[size];
        }

        public void Enqueue(int item)
        {
            if (_count == _items.Length) throw new Exception("Illegar item exception");
            _items[_rear] = item;
            _rear = (_rear + 1) % _items.Length;
            _count++;
        }

        public void Dequeue()
        {
            _items[_front] = 0;
            _front = (_front + 1) % _items.Length;
            _count--;
        }
        public void Print()
        {
            for (var i = 0; i < _items.Length; i++)
            {
                Console.WriteLine(_items[i]);
            }
        }
    }
}
