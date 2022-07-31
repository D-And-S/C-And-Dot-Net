using System;
using System.IO;

namespace WorkingWithDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directory and directory info similiar as file and fileInfo 
            // Directory provides static method 
            // Directory Info Provides instantiate method 
            // if we use large number operation with directory or file and then it is recommended to use instantiate method
            // because operating system check some security if it is static which affect the performance of the application

            Directory.CreateDirectory(@"c:\temp\folder1");

            //get files from directory, search pattern means which type of file should i need. 
            // e.g give me over only jpg file
            // searchOption.Alldirectories will search the all file of image folder and subdirectories also
            var files = Directory.GetFiles(@"H:\Study\c#\Fundamentals", "*Program.cs*", SearchOption.AllDirectories);

            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            var directories = Directory.GetDirectories(@"H:\Study\c#\Fundamentals", "*.*", SearchOption.AllDirectories);

            foreach (var dc in directories)
            {
                Console.WriteLine(dc);
            }

            Directory.Exists("....");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
