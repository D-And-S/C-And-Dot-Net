using System;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('_', 10)
                   .AppendLine()
                   .Append("Header")
                   .AppendLine()
                   .Append('_', 10)
                   .Replace('_', '+')
                   .Remove(0, 10)
                   .Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);


        }
    }
}
