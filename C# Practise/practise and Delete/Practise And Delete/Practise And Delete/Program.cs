using System;

namespace Practise_And_Delete
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var strLow = "abc";
            var strCap = "ABC";
            var result = "equal to ";
            int x = 0;
            int pos = 1;

            x = string.CompareOrdinal(strLow, pos, strCap, pos, 1);

            if (x < 0) result = "less than";
            if (x > 0) result = "greater than";
            Console.WriteLine("CompareOrdinal(\"{0}\"[{2}], \"{1}\"[{2}]):", strLow, strCap, pos);
            Console.WriteLine("   '{0}' is {1} '{2}'", strLow[pos], result, strCap[pos]);
        }

    }
}
