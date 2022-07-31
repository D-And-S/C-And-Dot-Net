namespace RevisePractise
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation !=null)           
                Move(newLocation.X, newLocation.Y);                     
        }

    }
}
