using System;

namespace ExStackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new POST();

            Console.WriteLine("Please Enter Title");
            var title = Console.ReadLine();

            Console.WriteLine("Please Enter Description");
            var description = Console.ReadLine();

            var upAndDownVote = Console.ReadLine();

            post.PostData(title,description);
            post.UpVote(upAndDownVote);
            post.DownVote(upAndDownVote);

        }
    }
}
