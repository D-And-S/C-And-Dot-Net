using System;
using System.Collections.Generic;

namespace ArrayExcercise
{
    public class ArrayExcercise
    {
        public static void FacebookLikePattern()
        {
            var nameList = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter Different Names");
                var input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    nameList.Add(input);
                }
            }

            switch (nameList.Count)
            {
                case 0:
                    Console.WriteLine("Nobody Likes your post");
                    break;
                case 1:
                    Console.WriteLine("{0} Liked Your Post", nameList[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} Liked Your post", nameList[0], nameList[1]);
                    break;
                default:
                    Console.WriteLine("{0} {1} and {2} other Liked Your post", nameList[0], nameList[1], nameList.Count - 2);
                    break;
            }
        }
    }
}
