using System;

namespace EnumType
{
    class Program
    {
        // since enum is new type that's why we need to define in namespace lavel
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }
        /*
         * if we do not set any value to enum then the first object will be 0 and next object 1, and next object 2, 
         * and every member value will be incremented by 1
         * It is best practise to explicitly set value to enum because sometime jodi order increment hote thake tahole database ar value ar sathe nao mathc korte pare
          public enjum shippingMethod {
             RegularAirMail,
             RegisteredAirMail,
             Express
          } 
         */

        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;

            // internally enum is an integer so we can cast it 
            Console.WriteLine((int)method);

            // receive Data from third party. now imagine, i m getting data(3) from database. and i need to convert shipping method
            var methodId = 3;

            // to do that we need to casting shipping method
            Console.WriteLine((ShippingMethod)method);

            // make to enum to to string, console.writeline toString() method likhar dorkar nei karon implicility any string printed by console is string
            // but explicitly enumke string e convert korar jonno tostring lagbe
            Console.WriteLine(method.ToString());

            //if we have a string and we want to convert that into enum shippingmethod
            // we need to parse that, parsing means getting a string and converting that to diffrent type
            var methodName = "Express";

            //shipping method is target type
            var data = Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(data);

        }
    }
}
