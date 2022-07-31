using System;

namespace ParamsKeyWordDemo
{
    class Program
    {
        public static int add(params int[] a)
        {
            int sum = 0;
            foreach (var item in a)
            {
                sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.add(10,20,30,40));
            Console.ReadLine();    
        }
    }
}
