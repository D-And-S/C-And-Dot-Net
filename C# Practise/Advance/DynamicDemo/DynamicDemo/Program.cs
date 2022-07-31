using System;

namespace DynamicDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic name = "Mosh";
            name = 10;

            Console.WriteLine(name);

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;

            int i = 500000000;
            dynamic d = i;

            byte l = d;

            
        }
    }
}
