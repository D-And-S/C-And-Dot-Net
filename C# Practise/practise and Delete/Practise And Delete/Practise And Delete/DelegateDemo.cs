using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_And_Delete
{
    internal static class DelegateDemo
    {
        // we can use this method through predefine func deleta
        // jetar return type value type sei method ke amra predefine func delegate dara use korte pari
        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }

        // jetar kono return type nai sei method ke amra predefine action delegate hisebe use korte
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine("Action Delegate: " + x + y + z);
        }

        // jetar return type hocche boolean seta ke amra predicate delegate hisebe use korte pari
        public static bool CheckLength(string str)
        {
            if (str.Length < 5) return true;
            return false;
        }

        // tar mane function delegate return type always value type hobe
        // action delegate ar kono return type thakabe nah
        // and jeta predicate setar return type always boolean hobe
    }
}
