using System;

namespace StringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "MH Dip ";
            Console.WriteLine("Trim: '{0}'",fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'",fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: {0}",firstName);
            Console.WriteLine("LastName: {0}",lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName (Using Split): " + names[0]);
            Console.WriteLine("LastName: (Using Split):" + names[1]);

            fullName.Replace("MH", "Mohiminul");
            fullName.Replace('o', 'O');
            fullName.Replace(" ", "");

            Console.WriteLine(fullName.Replace("MH", "Mohiminul"));

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine("Price: in Currency Format {0}: "+price.ToString("C"));
        }
    }
}
