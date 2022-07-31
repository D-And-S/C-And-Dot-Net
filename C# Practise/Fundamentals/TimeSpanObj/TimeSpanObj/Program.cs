using System;

namespace TimeSpanObj
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);
             
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine(duration);

            // time span properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // modify timespan
            Console.WriteLine("Add Example " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // Time Span to ToString 
            Console.WriteLine("ToString" + timeSpan.ToString());

            // conversion froms string
            Console.WriteLine("Parse " + TimeSpan.Parse("01:02:03"));
        }
    }
}
