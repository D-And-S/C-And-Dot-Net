using Class.Math;
using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "JOHN";
            john.LastName = "SMITH";
            john.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(1,2);
            Console.WriteLine(result);
        }
    }
}
