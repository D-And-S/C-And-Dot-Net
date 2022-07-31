using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpCookie = new HttpCookie();
            httpCookie["name"] = "MHDIP";
            Console.WriteLine(httpCookie["name"]);
        }
    }
}
