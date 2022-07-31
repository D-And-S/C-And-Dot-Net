using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to bea very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);

            var number = new List<int>() { 1,5,2,3,0,9};
            var max = number.Max();

            System.Console.WriteLine(max);
        }
    }
}
