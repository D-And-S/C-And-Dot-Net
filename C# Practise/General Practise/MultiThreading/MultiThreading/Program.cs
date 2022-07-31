using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class Program
    {
        static int Total = 0;
        static void Main(string[] args)
        {
            var t1 = new Thread(Program.AddOneMillion);
            var t2 = new Thread(Program.AddOneMillion);
            var t3 = new Thread(Program.AddOneMillion);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("Total =" + Total);
        }

        static object _lock = new object();
        public static void AddOneMillion()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (_lock)
                {
                    Total++;
                }            
            }
        }
    }
}