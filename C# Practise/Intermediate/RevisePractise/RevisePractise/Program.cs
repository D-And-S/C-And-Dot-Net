using System;

namespace RevisePractise
{
    class Program
    {
        static void Main(string[] args)
        {
            UseOfIndexer();
        }

        #region == Chapter 1 classes Tutorial
        static void ForClassTutorial()
        {
            var p = Person.Parse("MHDIP");
            p.Introduce("Ratul");
        }
        static void ForConstructoriTutorial()
        {
            var customer = new Customer(1, "MHDIP");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order);
            customer.Orders.Add(order);
        }
        static void UseField()
        {
            var customer = new Customer(1);
            var order = new Order();
            customer.Orders.Add(order);
            customer.Orders.Add(order);

            // if we use promote method which re initialize the orders property. 
            // then it will give result 0 because it initialize again that's why we use readonly property
            //customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }
        static void UsePoints()
        {
            var point = new Point(5, 10);

            point.Move(null);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            point.Move(20, 30);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
        }
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5)); 
        }
        static void UseOutModifier()
        {
            //var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion Faild");
        }
        static void UseAccessModifer()
        {
            var person = new Person(new DateTime(1993, 10, 02));
            //person.Birthdate = new DateTime(1993,10,02);
            Console.WriteLine(person.Age);
            
            person.month = 18;
            var monthNumber = person.MonthNumber;
            Console.WriteLine(monthNumber);
        }
        static void UseOfIndexer()
        {
            var cookie = new HTTPCookie();
            cookie["name"] = "MHDIP";
            Console.WriteLine(cookie["name"]);
        }

        #endregion ===  End

        #region Upcasting And DownCasting

        static void UpcastAndDownCast()
        {
            var text = new Text();
            Shape shape = text;

            Text text2 = shape as Text;
             
        }

        #endregion



    }
}
