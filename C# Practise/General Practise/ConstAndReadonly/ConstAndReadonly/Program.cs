using System;

namespace ConstAndReadonly
{
    internal class Program
    {
        /*
            1. readonly : when we use readonly with a container. 
                we will never be able to change the value of variable next time
            
            2. const: apply the same defination

            ** what is the difference between readonly and const
            
            *readonly  is Runtime Constant --> 
            
            *const is compile time constant --> they are absoulite constant. 
             if we do not initialize it compiler will show error
         */
        private const int cmToMeters = 100;
        private static readonly double PI = 100;

        static void Main(string[] args)
        {
            
        }
    }
}
