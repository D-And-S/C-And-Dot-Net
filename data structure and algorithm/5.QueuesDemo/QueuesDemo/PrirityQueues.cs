namespace QueuesDemo
{
    public class PrirityQueues
    {
        // regular queue e jeta hoy seta holo amra back e data join kor prothome 10 join krlam then 20
        // kintu akhane amader 1 ar pore insert korte hobe 
        // all this item are sorted into ascending order 
        // insert(2)
        //[1,3, 5, 7]

        // prothom theke start korbo je number ta insert korbo seta ager tar sathe and porer tar sathe compare korbo  then ar por insert korbo
        // [item+1] = item
        // items[i+1] = items[i]

        // solving priority queue by array

        private int[] _items = new int[5]; // [1,3,4,5]
        private int _count;

        public void Insert(int item)
        {
            if (IsFull()) throw new Exception("Illegal Statement");

            // we will shift this code in seperate method;
            //int i;
            //for (i = _count - 1; i >= 0; i--)
            //{
            //    if (_items[i] > item)
            //        _items[i + 1] = _items[i];
            //    else
            //        break;
            //}

            var i = ShiftItemToInsert(item); 
            // befor it was _items[i+1] = item;
            _items[i] = item;
            _count++;
        }

        private int ShiftItemToInsert(int item)
        {
            int i;
            for (i = _count - 1; i >= 0; i--)
            {
                if (_items[i] > item)
                    _items[i + 1] = _items[i];
                else
                    break;
            }
            return i + 1;
        }

        private bool IsFull()
        {
            return _count == _items.Length;
        }

        public int Remove()
        {
            if (IsEmpty()) throw new Exception("Illegal Statement Exception");
            return _items[--_count];
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_items[i]);
            }
        }

    }
}
