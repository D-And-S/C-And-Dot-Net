using System;

namespace WorkingWithClass
{
    class Program
    {
        public class Person
        {
            public string Name;

            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0}, I am {1}", to,Name);
            }

            public static Person Parse(string str)
            {
                var person = new Person();
                person.Name = str;
                return person;
            }
        }
        static void Main(string[] args)
        {          
            var p = Person.Parse("John");
            //person.Name = "ratul";
             p.Introduce("dip");
        }
    }
}
