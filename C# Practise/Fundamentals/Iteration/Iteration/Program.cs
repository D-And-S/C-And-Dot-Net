using System;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ========== For Loop ==========
            // for loop
            //for (var i=1; i<=10; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        //Console.WriteLine(i);
            //    }
                
            //}

            //for (var i =10; i>=1;i--)
            //{
            //    if (i%2 ==0)
            //    {
            //        //Console.WriteLine(i);
            //    }
            //}
            //#endregion ============ End For Loop

            //#region ========== For and foreach diffrences 
            //var name = "John Smith";
            //for (var i = 0; i < name.Length; i++)
            //{
            //    //Console.WriteLine(name[i]);
            //}

            ////re write the same code in foreach loop. it's clear and easy because we don't need define the index 
            //foreach (var character in name)
            //{
            //    // Console.WriteLine(character);
            //}
            //#endregion

            //#region======== Iterate over Array
            ////iterate over array
            //var numbers = new int[] { 1, 2, 3, 4 };

            //foreach (var number in numbers)
            //{
            //    //Console.WriteLine(number);
            //}
            #endregion

            #region ======= while loop =========

            //var j = 0;
            //while (j <= 10)
            //{
            //    if (j % 2 == 0)
            //       // Console.WriteLine(j);
            //    j++;
            //}

            // we should use while loop when we don't know how many times the loop wil exute\

            while (true)
            {
                Console.WriteLine("Type your Name: ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;
                Console.WriteLine("@Echo: " + input);

            }

            #endregion


        }
    }
}
