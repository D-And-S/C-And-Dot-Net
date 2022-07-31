using System;
using System.IO;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var streamReader = new StreamReader(@"c:\file.zip");
            try
            {
               var content =  streamReader.ReadToEnd();               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamReader.Dispose();
            }
           
        }
    }
}
