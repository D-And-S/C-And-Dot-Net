namespace Polymorphism
{
     
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
        public ShapType Type { get; set; }
        public abstract void Draw();
    }
}
