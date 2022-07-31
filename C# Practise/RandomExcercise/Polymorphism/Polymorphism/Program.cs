using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new List<Shape>();
            shape.Add(new Circle());
            //shape.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shape);

        }
    }
}
