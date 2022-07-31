using System;
using Generic;

namespace GenericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -- amra are equal method e integer pass korechi which is structure(value type) 
                -- but are equal methodparameter hocche object 
                -- so object theke integer (i mean value type theke reference type) e convert korte  
                -- kichu performance panalty hoy jader ke boxing and unboxing bole 
                -- converting value to reference type called boxing and vice versa called unboxing
                -- ar hocche jehetu parameter object sehetu amra je kono kichu pass korte pari
                -- like akta paramter e amra string arekta parameter amra integer pass kore campare korte pari 
                -- but it does not make any sense which lost the strongly type
                -- ai duto solve korar jonnoi generic
            */
            bool equal = Calculator.AreEqual(10, 10);

            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }


            // define generic type
            bool genericEqual = Calculator.AreEqual<String>("AB", "AB");
            if (genericEqual)
            {
                Console.WriteLine("Generic Equal");
            }
            else
            {
                Console.WriteLine("Generic Not Equal");
            }


            // We Made math class Generic 
            bool eq = Math<int>.AreEqual(10,12);
            if (eq)
            {
                Console.WriteLine("Match class Generic Equal");
            }
            else
            {
                Console.WriteLine("Match Generic Not Equal");
            }


            // **NOTE** -- We make also interface and delegate generic
        }
    }
}
