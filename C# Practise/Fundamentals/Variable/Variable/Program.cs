using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            // ======= Diffrent Data Type ======== //
            byte number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "MHDIp";
            var isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // ======= Display Min and Max Range of Variable ======
            Console.WriteLine("Byte Range Min To Max :"+"{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Integer Range Min To Max :" + "{0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Float Min To Max :" + "{0} {1}", float.MinValue, float.MaxValue);

            // ========== Make Const Variable which can't be modified ==========
            const float Pi = 3.14f;
            Console.WriteLine(Pi);

   
        }
    }
}
