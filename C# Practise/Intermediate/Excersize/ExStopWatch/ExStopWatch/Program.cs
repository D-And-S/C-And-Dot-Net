using System;
using System.Threading;

namespace ExStopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                var stopWatch = new StopWatch();
                stopWatch.Start();
                Thread.Sleep(1000);
                stopWatch.Stop();
                Console.WriteLine("Duration: " + stopWatch.GetInterval());
                Console.ReadLine();
            }
        }
    }
}
