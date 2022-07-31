using System;

namespace LinkedListDemo
{
    public class Node
    {
        public Node next;
        public int value;

        public Node(int value)
        {
            this.value = value;
        }
    }

    public class LinkedListDemo
    {
        private Node _first;
        private Node _last;
        private int _count;

        public void AddLast(int item)
        {
            var node = new Node(item);

            if (IsEmpty())
            {
                _first = _last = node;
            }
            else
            {
                _last.next = node;
                _last = node;
            }
            _count++;
        }

        public void AddFirst(int item)
        {
            var node = new Node(item);

            if (IsEmpty())
            {
                _first = _last = node;
            }
            else
            {
                var current = _first;
                node.next = current;
                _first = node;
            }
            _count++;

        }

        public void RemoveFirst()
        {

            IsEmptyWithException();

            var current = _first;
            _first = null;
            _first = current.next;
            _count--;
        }

        public void RemoveLast()
        {
            IsEmptyWithException();

            var current = _first;

            while (current.next != null)
            {
                if (current.next == _last)
                {
                    _last = null;
                    current.next = null;
                    break;
                }
                current = current.next;
            }
            _last = current;
            _count--;
        }

        public int IndexOf(int item)
        {
            var index = 0;
            var current = _first;
            while (current != null)
            {
                if (current.value == item) return index;
                index++;
                current = current.next;
            }
            return -1;
        }

        public bool Contains(int item)
        {
            return IndexOf(item) == -1;
        }

        public int[] ToArray()
        {
            var item = new int[_count];

            var current = _first;
            for (int i = 0; i < _count; i++)
            {
                item[i] = current.value;
                current = current.next;
            }
            return item;
        }


        public int GetKthFromTheEnd(int k)
        {
            if (k < 0) throw new Exception("ke cannot be negative");
            if (_count == k) throw new Exception("No such element");

            IsEmptyWithException();

            var a = _first; // fast
            var b = _first; // slow;


            for (var i = 0; i < k; i++)
            {
                b = b.next;
            }

            while (b.next != null)
            {
                a = a.next;
                b = b.next;
            }

            return a.value;
        }

        public void Reverse()
        {

            IsEmptyWithException();

            var previous = _first;
            var current = _first.next;

            _last = previous;
            _last.next = null;

            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            _first = previous;
        }

        public void PrintMiddle()
        {

            var a = _first;
            var b = _first;

            while (b != _last && b.next != _last)
            {
                a = a.next;
                b = b.next.next;
            }

            if (b == _last)
            {
                System.Console.WriteLine(a.value);
            }
            else
            {
                System.Console.WriteLine("{0} {1}", a.value, a.next.value);
            }
        }

        public bool HasLoop(Node _first)
        {
            if (IsEmpty()) throw new Exception("No Such element");

            var a = _first; // slow; one time
            var b = _first; // fast; two


            while (b != null && b.next != null)
            {
                a = a.next;
                b = b.next.next;

                if (a == b) return true;
            }
            return false;
        }

        private bool IsEmpty()
        {
            return _first == null;
        }

        private void IsEmptyWithException()
        {
            if (_first == null)
            {
                throw new Exception("No Such Element Exception");
            }
        }

        public void Print()
        {
            while (_first != null)
            {
                Console.WriteLine(_first.value);
                _first = _first.next;
            }
        }
    }
}