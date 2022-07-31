using System;

namespace ValueTypesAndReferenceTypes
{
    class Program
    {
        public class Person
        {
            public int Age;
        }

        static void Main(string[] args)
        {
            // Example One
            var a = 10;
            var b = a;
            b++;
            //Console.WriteLine("{0} {1}", a, b);

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            //Console.WriteLine("arry1[0]: {0}, array2[0]: {1}", array1[0],array2[0]);

            // Example Two 
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
        }

        public static void Increment(int number)
        {
            number += 10;          
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
