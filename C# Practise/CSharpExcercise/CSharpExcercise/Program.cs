using System;

namespace CSharpExcercise
{
    class Program
    {
        private static readonly int[] _firstArray = new int[] { 10, 9, 3, 8, 7 };
        private static readonly int[] _secondArray = new int[] { 10, 9, 3, 8, 7 };
        static void Main(string[] args)
        {
            var strings = StringExcercise.Capitalize("hello world");
       
            Console.WriteLine(LeetCode.TwoStringAreClose("cabbba","abbccc"));

        }     
    }

}
