using System;
using System.Collections.Generic;

namespace SummarizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really long text";
            var summary = StringUtility.SummerizeText(sentence,25);
            Console.WriteLine(summary);
        }

    }
}