using System;
using System.Collections.Generic;

namespace LinkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedListDemo();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            list.AddLast(60);

            //list.AddLast(70);
            //list.AddLast(70);
            //list.AddFirst(5);
            //list.AddFirst(10);
            //list.AddFirst(30);
            //list.RemoveFirst();

            //list.RemoveLast();

            //Console.WriteLine(list.IndexOf(60));

            //Console.WriteLine(list.Contains(10050));

            //Console.WriteLine(list.GetKthFromTheEnd(2));

            // list.Reverse();

            //  list.PrintMiddle();

            var node = new Node(1);
            node.next = new Node(2);
            node.next.next = new Node(3);
            node.next.next.next = new Node(4);
            //node.next.next.next.next = node.next;

            System.Console.WriteLine(list.HasLoop(node)); ;

            //Console.WriteLine("The middle node is "+list.PrintMiddle());

            // var array = list.ToArray();
            // foreach (var item in array)
            // {
            //     Console.Write("{0} {1}", item," ");
            // }

            // list.Print();

        }
    }
}
