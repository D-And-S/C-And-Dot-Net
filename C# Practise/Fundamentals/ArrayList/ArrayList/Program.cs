using System;
using System.Collections.Generic;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1,2,3,4};
            numbers.Add(1); // to add one object
            numbers.AddRange(new int[3] {5,6,7}); // to add another list

            foreach (var number in numbers)
                Console.WriteLine(number);

            // some time you need to search from the beggining of the list so use indexOf
            Console.WriteLine("\nIndex Of");
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1)); // find the first index of number 1

            // some time you need to search from the end of the list so use last indexof
            Console.WriteLine("\nLast Index Of");
            Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1)); // find out the last index of number 1

            // using count
            Console.WriteLine("Count: "+ numbers.Count);

            // using remove method 
            numbers.Remove(1);

            Console.WriteLine("\nRemove the first 1");
            foreach (var number in numbers)
                Console.WriteLine(number);
            
            Console.WriteLine("\nRemove all from the list 1");


            for(var i= 0; i<numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(1);
            }
            foreach (var number in numbers)
                Console.WriteLine(number);

            //Clear method remove all elemetn from the list 
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);

        }
    }
}
