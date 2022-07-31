using System;

namespace O_N_Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //nested loop O(n^2)
        public void log(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i);
            }

            for (int first = 0; first < numbers.Length; first++)
            {
                for (int second = 0; second < first; second++)
                {
                    Console.WriteLine(first + " "+ second);
                }
            }
        }


    }
}
