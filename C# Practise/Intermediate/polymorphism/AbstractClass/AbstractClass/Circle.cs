using System;

namespace AbstractClass
{
    public sealed class Circle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle");
        }
    }
}
