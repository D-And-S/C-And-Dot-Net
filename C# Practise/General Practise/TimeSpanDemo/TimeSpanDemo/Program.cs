using System;

namespace TimeSpanDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date1 = new DateTime(2022,4,2,8,40,15);

            var date2 = new DateTime(1993,10,2,9,18,30);

            TimeSpan interval = date1 - date2;

            Console.WriteLine(interval.Ticks);
        }
    }
}
