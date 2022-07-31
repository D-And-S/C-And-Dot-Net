using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1,1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: "+ now.Hour);
            Console.WriteLine("Minute: "+ now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            // Date Time has bunch of method to converting it string format
            Console.WriteLine("Long Date: "+ now.ToLongDateString());
            Console.WriteLine("Short Date: "+now.ToShortDateString());
            Console.WriteLine("Long Time: "+now.ToLongTimeString());
            Console.WriteLine("Short Time: "+now.ToShortTimeString());

            //Display both date and time 
            Console.WriteLine(now.ToString());

            // display date with formate specifier
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:MM"));
        }
    }
}
