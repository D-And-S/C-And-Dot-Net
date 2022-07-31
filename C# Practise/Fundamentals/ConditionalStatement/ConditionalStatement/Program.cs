using System;

namespace ConditionalStatement
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // if else 
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's Evening");
            }

            // conditional operator 
            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;

            //ternary operator 
            float prices = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(prices);

            //switch case 
            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("Its beautiful season");
                    break; 
                case Season.spring:
                    Console.WriteLine("It's perfect to go to beach");
                    break;
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
        }
    }
}
 