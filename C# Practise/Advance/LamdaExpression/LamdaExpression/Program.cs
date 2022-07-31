using System;

namespace LamdaExpression
{
    public class BookRepository
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //n => number * number
            // () => ... if there is no argument
            // x => ... if there is one argument
            // (x,y,z) => ... if there is multiple argument

            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));
        }

    }
}
