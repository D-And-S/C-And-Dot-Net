using System;

namespace array_in_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //length 
            Console.WriteLine("Length: "+ numbers.Length);
           
            //IndexOf()
            var index =  Array.IndexOf(numbers, 9, 1);
            Console.WriteLine(index);

            // clear method
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("\nEffect of clear() method");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //copy method, we will copy some number element to another array
            Console.WriteLine("\nEffect fo copy() method");
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            
            foreach (var n in another)
                Console.WriteLine(n);

            //Sort
            Console.WriteLine("\n Aarry Sort");
            Array.Sort(numbers);

            foreach (var n in numbers)
                Console.WriteLine(n);

            //Reverse
            Console.WriteLine("\n Aarry Reverse");
            Array.Reverse(numbers);

            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
