using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1993,10,2));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}
