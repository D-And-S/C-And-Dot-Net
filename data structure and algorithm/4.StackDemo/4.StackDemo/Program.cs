using System;
using System.Collections;
using System.Collections.Generic;

namespace _4.StackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            var stringDemo = new StringDemo();

            //var data = "ABCD";
            //stringDemo.StringReverse(data);

            var balanceString = stringDemo.BalanceString("(((( 3<4>)<5>)<6> {7}  ))");
            Console.WriteLine(balanceString);

            var stack = new StackDemo();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
                    
            //stack.Peek();
            var popData = stack.Pop();
            //Console.WriteLine("The Pop Data is"+ popData);

            Console.WriteLine("The Top Data of this stack is "+stack.Peek());
            stack.Print();
        }

    }

}
