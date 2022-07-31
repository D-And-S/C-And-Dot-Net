using System;

namespace Operator
{
    class Program
    {
        static object Main(string[] args)
        {
            var a = 10;
            var b = 2;
            var c = 3;

            // if i want to convert the integer to float
            Console.WriteLine((float)a/b);

            // multiply and division operator have higher precedence
            Console.WriteLine(a+b * c); // result is 16
            Console.WriteLine((a+b)*c); // result is 36

            // comparison operator
            Console.WriteLine("Comparison Opearotr a > b --"+ (a > b));
            Console.WriteLine("Comparison Opearotr a == b --" + (a == b));
            Console.WriteLine("Comparison Opearotr a != b --" + (a != b));

            // tricity comparison example 
            Console.WriteLine("Comparison Opearotr !(a != b) " + (!(a != b)));

            // logical && operator 
            Console.WriteLine("Logical Comparison true &&--" + (c>b && c < a)); 
            Console.WriteLine("Logical Comparison false &&--" + (c>b && c == a));

            // logical || operator 
            Console.WriteLine("Logical Comparison || --" + (c > b || c == a));

            Program.Main2;

        }

    }

    
}
