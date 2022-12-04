using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    internal class LeetCode
    {


        //1657. Determine if Two Strings Are Close
        public static bool TwoStringAreClose(string word1, string word2)
        {
            var w1 = word1.ToLower();
            var w2 = word2.ToLower();

            if ((w1.Length == 0 || w2.Length == 0) || (w1.Length != w2.Length)) return false;

            //use hashset because it doesn't allow duplicate
            var setWord1 = new HashSet<char>();
            var setWord2 = new HashSet<char>();

            var countWord1 = new int[26];
            var countWord2 = new int[26];

            foreach (char c in w1)
            {
                setWord1.Add(c);
                countWord1[c - 'a']++;
            }

            foreach (char c in w2)
            {
                setWord2.Add(c);
                countWord2[c - 'a']++;
            }

            var i = setWord1.OrderBy(s => s).ToArray();
            var j = setWord2.OrderBy(s => s).ToArray();

            return i.SequenceEqual(j) && (countWord1.OrderBy(s=>s)).SequenceEqual(countWord2.OrderBy(s=>s));
            
        }
    }
}
