using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.HashTable
{
    internal class HashTable
    {
        private int key;
        private string value;

        public HashTable()
        {

        }

        public HashTable(int key, string value)
        {
            this.key = key;
            this.value = value;
        }

        private LinkedList<HashTable>[] _entries = new LinkedList<HashTable>[5];

        public void Put(int key, string value)
        {
            var index = Hash(key);

            if (_entries[index] == null)
                _entries[index] = new LinkedList<HashTable>();

            var bucket = _entries[index];

            foreach (var entry in bucket)
            {
                if (entry.key == key)
                {
                    entry.value = value; // if the key is same we will update the value
                    return;
                }
                else
                {
                    bucket.AddLast(new HashTable(key, value));
                    return;
                }
            }

            bucket.AddLast(new HashTable(key, value));
        }

        public string Get(int key)
        {
            var index = Hash(key);
            var bucket = _entries[index];

            if (bucket != null)
            {
                foreach (var entry in bucket)
                {
                    if (entry.key == key)
                        return entry.value;
                }
            }

            throw new Exception("Illegal statement provided");
        }

        public void Remove(int key)
        {
            var index = Hash(key);
            var bucket = _entries[index];

            if (bucket == null)
                throw new Exception("Illegal Statement");

            foreach (var entry in bucket)
            {
                if (entry.key == key)
                    bucket.Remove(entry);
                return;
            }
        }


        // whatever key we have we will reduce it by size of our array
        private int Hash(int key)
        {
            return key % _entries.Length;
        }
    }
}
