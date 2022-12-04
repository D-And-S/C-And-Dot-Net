using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.HashTable
{
    internal class HashTableRefactoring
    {
        private int key;
        private string value;

#nullable disable
        public HashTableRefactoring()
        {

        }

        public HashTableRefactoring(int key, string value)
        {
            this.key = key;
            this.value = value;
        }

        private LinkedList<HashTableRefactoring>[] _entries = new LinkedList<HashTableRefactoring>[5];

        public void Put(int key, string value)
        {
            var entry = GetEntry(key);

            if (entry != null && entry.key == key)
            {
                GetOrCreateBucket(key).AddLast(new HashTableRefactoring(key, value));
                return;
            }
            else if (entry != null)
            {
                entry.value = value;
                return;
            }

            GetOrCreateBucket(key).AddLast(new HashTableRefactoring(key, value));
        }

        public string Get(int key)
        {
            var entry = GetEntry(key);
            return entry == null ? null : entry.value;
        }

        public void Remove(int key)
        {
            var entry = GetEntry(key);

            if (entry == null)
                throw new Exception("Illegal Exception");

            GetBucekt(key).Remove(entry);
        }

        private LinkedList<HashTableRefactoring> GetOrCreateBucket(int key)
        {
            var index = Hash(key);
            var bucket = _entries[index];

            if (bucket == null)
                _entries[index] = new LinkedList<HashTableRefactoring>();

            return bucket;
        }

        private LinkedList<HashTableRefactoring> GetBucekt(int key)
        {
            var index = Hash(key);
            return _entries[index];
        }

        private HashTableRefactoring GetEntry(int key)
        {
            var index = Hash(key);
            var bucket = _entries[index];

            foreach (var entry in bucket)
            {
                if (entry.key == key)
                    return entry;
            }
            return null;
        }

        // whatever key we have we will reduce it by size of our array
        private int Hash(int key)
        {
            return key % _entries.Length;
        }
    }
}
