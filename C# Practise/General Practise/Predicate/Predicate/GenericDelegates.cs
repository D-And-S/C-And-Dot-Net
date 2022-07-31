using System;

namespace Predicate
{
    //we commented it because we want to use predefine delegate instead of custom delegate
    //public delegate double Delegate1(int x, float y, double z);
    //public delegate void Delegate2(int x, float y, double z);
    //public delegate bool Delegate3(string str);
    public static class GenericDelegates
    {
        // we can use this method through predefine func delegate. [deligat which focus to value return type]
        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }

        // we can use this method through predefine Action delegate. [deligat which focus to void return type]
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine("Action delegate: " + x + y + z);
        }

        // we can use this method through predefine Predicate delegate. [deligat which focus to bool return type]
        public static bool CheckLength(string str)
        {
            if (str.Length < 5) return true;
            return false;
        }
    }
}