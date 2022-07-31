using System;

namespace Methods
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int number;
            var result = int.TryParse("abc",out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion Fail");

        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch (Exception e)
            {

            }
        }
    }
}
