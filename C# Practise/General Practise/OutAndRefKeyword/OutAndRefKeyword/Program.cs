using System;

namespace OutAndRefKeyword
{
    internal class Program
    {
        /*
         * out and ref are c# key word which help you to pass variable to method by referance
         
              1. kono function ar paramter e jokhon amra kono value pass kori like function(string a, int b).
                 tokhon jodi amra out or ref key word use kori tokhon  function(out string a, ref int b) avabe
                 use korle amra parameter ke referance hisebe use korte parbo
        */
        static void Main(string[] args)
        {
            /*
             *   ref keyword: helps value to pass by reference
                 1. amra outside value 20 nie Addition function e sei value pathiye diyechi
                 2. and adition function e amra aditional value ar sathe 10 add korechi 
                 3. but result dear kotha 30 kintu result hobe 20
                 4. because when the data was passed it was passed by value
                 5. now jodi amra ref key word use kore tahole it will give result 30 
                 6. ref keyword use korle always value initialize kora lage
             */

            /*
                out keyword: out key word also help value to pass by referance 
                1. but jokhon out keyword use korbo tokhon function ar vitore must value initialize korte hobe
                2. see PassByout function where we initialize the value parameter
                3. jokhon out keyword use kortesi tokhon amra je value pass kori ki na function ar baire theke,
                   always function ar inside value tai initialize hobe
            */

            /*
                ** difference between ref and out
                1. both key word used value to pass by referance 
                2. value must be initialize out side of the function when it comes to use ref keyword
                3. value must be initialize inside of the function when it comes ot use out keyword
                
             */

            /*
                ** in is also used to value to pass by reference
                1. but we cannot change value
             */

            int outsideValue = 20;
            Addition(ref outsideValue);
             Console.WriteLine("OutSideValue: "+outsideValue);

            int value = 30;
            PassByOut(out value);

            var person = new Person("MH", "Dip");
            Print(person);
        }

        static void Addition(ref int insideValue)
        {
            //insideValue = 10;
            insideValue = insideValue + 10;
        }

        static void PassByOut(out int value)
        {
            value = 10;
            Console.WriteLine("myValue = {0}", value);
        }

        static void Print(in object input)
        {
            //since we use in keyword so we cannot change the value of input
            //input = new Person("Noshin", "Sayara");
            //Console.WriteLine(input);
        }

    }

    public record Person(string FirstName, string LastName)
    {
        public string ShowData() => $"{FirstName} {LastName}";
    }
}
