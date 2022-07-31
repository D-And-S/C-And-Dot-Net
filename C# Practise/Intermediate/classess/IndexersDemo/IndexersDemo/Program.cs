using System;

namespace IndexersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "MHDIP";
            Console.WriteLine(cookie["name"]);
        }
    }
}
