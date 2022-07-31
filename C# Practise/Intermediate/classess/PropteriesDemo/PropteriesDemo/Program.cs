using System;
namespace PropteriesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1993, 10, 2));
            //person.Birthdate = new DateTime(1993,10,2);
            System.Console.WriteLine(person.Age);

        }
    }
}
