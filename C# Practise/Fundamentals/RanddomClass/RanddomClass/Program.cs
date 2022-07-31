using System;

namespace RanddomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // random number
            var random = new Random();
            for (var i = 0; i < 10; i++)
                Console.WriteLine(random.Next(1,10));

            // random character because computer don't understand character they understand number
            Console.WriteLine((int)'a');

            //generate random string 
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a'+random.Next(0, 26));

            var password = new string(buffer);
            Console.WriteLine(password);


        }
    }
}
