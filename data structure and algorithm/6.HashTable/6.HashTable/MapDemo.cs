using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.HashTable
{
    internal class MapDemo
    {

        // find the first non repeated character in string
        // we should write method that return G as non-repeated character 
        public char FindFirstNonRepeatingChar(string str)
        {
            var dictionary = new Dictionary<char, int>();
            var characters = str.ToString();

            foreach (char ch in characters)
            {
                if (dictionary.ContainsKey(ch))
                {
                    var count = dictionary[ch];
                    dictionary[ch] = count + 1;
                }
                else
                {
                    dictionary.Add(ch, 1);
                }
            }

            foreach (var item in dictionary)
            {
                if (item.Value == 1)
                    return item.Key;
            }

            return char.MinValue;
        }

        // find the first repeating character 
        public char FindFirstRepeatingCharacter(string str)
        {
            var set = new HashSet<char>();

            foreach (char ch in str.ToCharArray())
            {
                if (set.Contains(ch))
                    return ch;

                set.Add(ch);

            }

            return char.MinValue;
        }


        public int hash(int number)
        {
            return number % 100; // here we assume that 100 is size of array
        }

        public int hash(string key)
        {
            int hash = 0;
            foreach (char ch in key.ToCharArray())
                hash += ch; // here the character autometically converted to integer (which is called implicit casting)

            return hash % 100;
        }

    }
}
