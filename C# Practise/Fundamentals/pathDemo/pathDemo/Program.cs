using System;
using System.IO;

namespace pathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\project\fandamental.cs\helloworld.sln";
            Console.WriteLine("Extension: "+Path.GetExtension(path));
            Console.WriteLine("File Name: "+Path.GetFileName(path));
            Console.WriteLine("File Name without extentions: "+Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: "+Path.GetDirectoryName(path));

        }
    }
}
