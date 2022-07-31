using System;

namespace Arrays
{
    public class ArraysFunction
    {
        private int[] _items;
        private int _count;
        public ArraysFunction(int size)
        {
            _items = new int[size];
        }

        public void Insert(int item)
        {

            if (_items.Length == _count)
            {
                var newItem = new int[_count * 2];

                for (var i = 0; i < _count; i++)
                {
                    newItem[i] = _items[i];
                }
                _items = newItem;
            }

            _items[_count] = item;
            _count++;
        }

        public void RemoveAt(int index)
        {
            if (_count == index) throw new Exception("Illegal Index Exception. Index outside of range");
            for (var i = index; i <= _count; i++)
            {
                _items[i] = 0;
                _count--;
            }
        }

        public int IndexOf(int item)
        {
            var index = 0;
            for (int i = 0; i < _count; i++)
            {
                if (_items[i] == item) return index;
                index++;
            }
            return -1;

        }

        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
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
