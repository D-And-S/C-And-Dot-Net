using System;

namespace Methods
{
    partial class Program
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

                /*
                  amader ager move method e already x and y define korechi abr new movie method seta repeat korechi
                  ata kora ta bad practise. ar bodole amra prothom move method tai call krbo
                 */
                //X = newLocation.X;
                //Y = newLocation.Y;

                /*
                  akhono ai method e slight problem royeche jodi amra null pathai tahole error dibe 
                  sekhetre amader validation korte hobe
                 */
                if (newLocation == null)
                    throw new ArgumentNullException("newLocation");
                Move(newLocation.X, newLocation.Y);

            }
        };
    }
}
