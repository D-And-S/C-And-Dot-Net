using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace UpacastingAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = text;

            Text text2 = (Text)shape;
            text2.Draw();
        }
    }
}
