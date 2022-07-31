using System;
using System.Collections.Generic;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new ArraysFunction(3);
            array.Insert(10);
            array.Insert(20);
            array.Insert(30);
            array.Insert(40);
            array.Insert(50);
            array.Insert(60);
            array.RemoveAt(5);
             Console.WriteLine("Index Of {0} = {1}", 50, array.IndexOf(50));
             Console.WriteLine(array.Contains(50));    
            array.Print();
        }
    }
}
