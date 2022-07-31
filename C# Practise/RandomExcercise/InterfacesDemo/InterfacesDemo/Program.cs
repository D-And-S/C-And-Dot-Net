using System;

namespace InterfacesDemo
{
    interface ICustomer
    {
        void Print1();
    }

    interface ICustomer2 : ICustomer
    {
        void Print2();

    }
    class Customer : ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Interface Print Method");
        }
        public void Print2()
        {
            Console.WriteLine("InterFaces Print 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                       
        }
    }
}
