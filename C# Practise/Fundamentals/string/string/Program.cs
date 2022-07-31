using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {          
            var firstName = "MH";
            var lastName = "Dip";

            var fullName = firstName + " " + lastName;
            var myfullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myfullName);

            // string join method
            var names = new string[3] {"john", "jack", "antor"};
            var formatedNames = string.Join(",",names);
            Console.WriteLine(formatedNames);

            //verbatim string
            var text = "Hi John\n Look into the following paths\nc:\\forlder1\\folder2\nc:\\forlder3\\folder4";
            var verbatimString = @"Hi John
Look into the following paths
C:\folder1\folder2
C:\folder3\folder5";
            Console.WriteLine(verbatimString);
        }
    }
}
