using System;

namespace CSharpExcercise
{
    class BegginerExcercise
    {

        /*
         * 1.
            Write a C# Sharp program to swap two numbers. Go to the editor
            Test Data:
            Input the First Number : 5
            Input the Second Number : 6
            Expected Output:
            After Swapping :
            First Number : 6
            Second Number : 5
         */
        public static void SwapNumber()
        {
            Console.WriteLine("Enter The First Number");
            var input = Console.ReadLine();
            var number1 = int.Parse(input);

            Console.WriteLine("Enter The Second Number");
            var input2 = Console.ReadLine();
            var number2 = int.Parse(input2);

            var firstNumber = number2;
            var secondNumber = number1;

            Console.WriteLine("After Swapping");
            Console.WriteLine("The First Number: {0}, The Second Number {1}", firstNumber, secondNumber);
        }
    }
}
