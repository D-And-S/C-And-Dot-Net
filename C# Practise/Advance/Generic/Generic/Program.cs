using System;
namespace Generic
{
    public class Calculator<T>
    {
        public static bool AreEqual(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    } 

    class Program
    {
        static void Main (string[] args)
        {
            bool equal = Calculator<string>.AreEqual("A", "C");

            if (equal)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");

        }

    }
}
