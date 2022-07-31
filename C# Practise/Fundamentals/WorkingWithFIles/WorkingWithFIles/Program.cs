using System;
using System.IO;

namespace WorkingWithFIles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg",@"d:\temp\myfile.jpg");
            File.Delete(path);
            if (File.Exists(path))
            {
                ///
            }

            var content = File.ReadAllText(path);

            // file Info
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                ///
            }


        }
    }
}
