using System;
using System.Collections.Generic;

namespace CSharpExcercise
{
    class ControlFlowExcercise
    {
        /* 
          1. 
          Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
          Display the count on the console
        */
        public static void TotalNumberCount()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count = count + 1;
                }

            }
            Console.WriteLine("Total Number Count Between 1 to 100 are: " + count);
        }

        /*
          2. 
          Write a program and continuously ask the user to enter a number or "ok" to exit. 
          Calculate the sum of all the previously entered numbers and display it on the console.
        */
        public static void CalculateTheSumOfPreviousEnteredNumber()
        {
            int input = 0;
            var number = 0;

            while (true)
            {
                Console.WriteLine("please enter a number");
                var value = Console.ReadLine().ToLower();
                if (value == "ok")
                {
                    break;
                }
                else
                {
                    input = int.Parse(value);
                    number += input;
                }
                Console.WriteLine("total is {0} ", number);
            }
        }

        /*
          3. 
          Write a program and ask the user  to enter a number. 
          Compute the factorial of the number and print it on the console. 
          For example, if the user enters 5, 
          the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
         */
        public static void GenerateFactorial()
        {
            Console.WriteLine("Please Enter Number");
            var input = Console.ReadLine();
            var numebr = Convert.ToInt32(input);
            var factorial = 1;

            for (int i = numebr; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(numebr+"!= {0}", factorial);
        }

        /*
           4. 
         Write a program that picks a random number between 1 and 10. 
         Give the user 4 chances to guess the number. 
         If the user guesses the number, display “You won"; otherwise, display “You lost". 
         (To make sure the program is behaving correctly, you can display the secret number on the console first.)
        */
        public static void GuessTheRandom()
        {
            Console.WriteLine("Picks a random between 1 and 10");
            var rnd = new Random();
            var number = rnd.Next(1,10);
            Console.WriteLine("The Secret Number is {0}", number);

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Enter Number");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == number)
                {
                    Console.WriteLine("You Won");
                    break;
                }
                if (i == 4)
                {
                    Console.WriteLine("You Lost");
                    break;
                }
            }
        }

        /*
          5. 
          Write a program and ask the user to enter a series of numbers separated by comma. 
          Find the maximum of the numbers and display it on the console. 
          For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        */
        public static void FindMaxNumberOfSeries()
        {
            Console.WriteLine("enter a series of numbers separated by comma");
            var input = Console.ReadLine();
            var numbers = input.Split(",");
            var max = 1;

            foreach (var item in numbers)
            {
                var number = Convert.ToInt32(item);
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine("Max is {0}", max);
        }

        /*
         6.
            Write a program in C# Sharp to display the cube of the number up to given an integer.
         */
        public static void CubeNumebr()
        {
            Console.WriteLine("Enter a given Integer");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            for (int i = 1; i < number; i++)
            {
                Console.WriteLine("Number is {0} and cube of the {1} is : {2}",i,i,i*i*i);
            }
        }

        /*
          6.
             Write a program in C# Sharp to display the multiplication table of a given integer
          */
        public static void MultiplicationTable()
        {
            while (true)
            {
                Console.WriteLine("Enter The Given Integer");
                var input = Console.ReadLine();
                var number = Convert.ToInt32(input);

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }else
                {
                    for (int i = 1; i <=10 ; i++)
                    {
                        Console.WriteLine("{0} * {1} = {2}",number, i, number * i);
                    }
                }
                Console.WriteLine("\n");
            }
        }

        /*
            7.
            Write a program in C# Sharp to display 
            the multiplication table vertically from 1 to n
         */
        public static void VerticalMultiplicationTable()
        {
            Console.WriteLine("Enter number");
            var n = int.Parse(Console.ReadLine());

            for (var i=1;i<=10;i++)
            {
                for (var j=1;j<=n;j++)
                {
                   Console.Write("{0} * {1} = {2},  ", j, i, j * i);           
                }
                Console.Write("\n");
            }



            //Console.WriteLine("Enter A Number");
            //var input = Console.ReadLine();
            //var number = Convert.ToInt32(input);

            //for (int i = 1; i <= number; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("{0} * {1} ={2} ", i, j, i * j);
            //    }
            //    Console.WriteLine("\n");
            //}
        }

        /*
         8.
           Write a program in C# Sharp to make such a pattern 
           like right angle triangle 
           with a number which will repeat a number in a row             
        */
        public static void RepeatRowPattern()
        {
            Console.Write("\n\n");
            Console.Write("Display the pattern like right angle triangle which repeat a number in a row:\n");
            Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");
            var rows = int.Parse(Console.ReadLine());

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j<=i; j++)
                {
                    Console.Write("{0}",i);                   
                }
                Console.Write("\n");
            }
        }

        /*
           Write a C# Sharp program to display alphabet pattern like A with an asterisk                                   
        ---------------------------------------------                                                                                                                 
          ***                                                                            
         *   *                                                                           
         *   *                                                                           
         *****                                                                           
         *   *                                                                           
         *   *                                                                           
         *   *                                                                           
         *   *           
        */

        public static void AShape()
        {
            for (int row = 0; row <=7; row++)
            {
                //Console.Write("*");
                for (int column = 0; column <=7; column++)
                { 
                    if (((column == 1 || column == 5) && row !=0) || 
                       ((row == 0 || row ==3) && (column >1 && column < 5)))
                    {
                        Console.Write("*");                                                 
                    }else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.Write("\n");
            }
        }

        /*
         C# program in B Shape

         ****                                                                            
         *   *                                                                           
         *   *                                                                           
         ****                                                                            
         *   *                                                                           
         *   *                                                                           
         **** 
         
         */
        public static void BShape()
        {
            for (int row = 0; row <=6; row++)
            {
                for (int column = 0; column <=6; column++)
                {
                    if (((column <= 3) && row !=1 && row != 2 && row != 4 && row !=5) ||
                       (row == 1 || row == 2 || row == 4 || row == 5) && (column == 0 || column == 5)) 
                    {
                        Console.Write("*");
                    }else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }

}
