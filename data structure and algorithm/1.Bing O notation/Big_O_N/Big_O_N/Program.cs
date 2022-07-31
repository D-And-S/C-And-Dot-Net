using System;

namespace Big_O_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //simple loop O(n)
        public void log(int[] numbers, string[] names)
        {
            // the runtime complexity O (n) we don't know the size of inpu
            for (int i = 0; i < numbers.Length; i++) // O(n)
            {
                Console.WriteLine(numbers[i]);
            }

            for (int i = 0; i < names.Length; i++) // O(m)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
