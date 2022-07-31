using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void Log(int[] numbers)
        {
            // 0(1)
            Console.WriteLine(numbers[0]);
        }
    }
}
