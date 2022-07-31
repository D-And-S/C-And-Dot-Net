using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ======== Cast integer to Byte without data loss =====*/
            /*int i = 1000;
            byte b = (byte)i;
            Console.WriteLine(b);*/

            /* ======== We cannot explicitly convert string to int that's whey we need to use convert class ==========*/
            var number = "1234";
            int i = Convert.ToInt32(number);
            //Console.WriteLine(i);

            /* ======== What If we Convert to byte and handle exception =======*/
            try
            {
                var number2 = "1234";
                byte j = Convert.ToByte(number2);
                Console.WriteLine(j);
            }
            catch (Exception)
            {
                // Console.WriteLine("The number could not be converted to byte");
            }

            /* ======== Convert String to Boolean =======*/
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
