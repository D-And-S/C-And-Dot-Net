using System;

namespace Predicate
{
    /*
        Node: When it comes to the delegate we can define delegate and implement our requirement.
              just like we define the signature and someone implement it according to their requirement
              but most case we do not need to define custom delegate. C# already have predefine delegate
             
        there are some predefine delegates in c# 
        1. func -- delegate -- when a method return some value like string, int, double but return something
        2. action -- delegate -- when a method does not return any thing is  void
        3. predicate -- delegate -- when a return type is boolean
    */
    internal class Program
    {
        static void Main(string[] args)
        {

            //var delegate1 = new Delegate1(GenericDelegates.AddNums1);
            //var result1 = delegate1(100, 34.5f, 193.90);
            //Console.WriteLine("First Delegate: " + result1);

            //var delegate2 = new Delegate2(GenericDelegates.AddNums2);
            //delegate2.Invoke(100, 34.5f, 290.90);

            //var delegate3 = new Delegate3(GenericDelegates.CheckLength);
            //var result2 = delegate3("Hello World");
            //Console.WriteLine("third delegate: "+result2);

            var func = new Func<int, float, double, double>(GenericDelegates.AddNums1);
            var result = func.Invoke(100, 34.5f, 193.90);
            Console.WriteLine("Func: "+result);

            var action = new Action<int, float, double>(GenericDelegates.AddNums2);
            action.Invoke(100, 34.5f, 193.90);

            var predicate = new Predicate<string>(GenericDelegates.CheckLength);
            Console.WriteLine("Predicate " +predicate("15247898"));
        }
    }
}
