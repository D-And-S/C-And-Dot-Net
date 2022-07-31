using System;

namespace ExStackOverFlowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            UsePost(); 
        }

        static void UsePost()
        {
            var post = new Post();

            Console.WriteLine("Please Enter Title");
            var title = Console.ReadLine();

            Console.WriteLine("Please Enter Description");
            var description = Console.ReadLine();

            post.PostData(title, description);

            while (true)
            {
                Console.WriteLine("\nDo you want to Upvote? Y/N");
                var upVote = Console.ReadLine().ToLower();
                if (upVote == "y")
                {
                    post.UpVote();
                }
                else
                {
                    break;
                }

            }


            while (true)
            {
                Console.WriteLine("\n Do you want to Down? Y/N");
                var downVote = Console.ReadLine().ToLower();
                if (downVote == "y")
                {
                    post.DownVote();
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine("Total Vote: " + post.DisplayCurrentVoteValue());
        }
    }
}
