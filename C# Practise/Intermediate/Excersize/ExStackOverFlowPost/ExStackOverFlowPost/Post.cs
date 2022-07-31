using System;

namespace ExStackOverFlowPost
{
    public class Post
    {
        private int _upVote;
        private int _downVote;
        private DateTime _dateTime;

        public void PostData(string title, string description)
        {
            _dateTime = DateTime.Now;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
                throw new OperationCanceledException("Title and Descripton Should be Enter");
          
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("\n");
            Console.WriteLine("Description: {0}", description);
            Console.WriteLine("\n");
            Console.WriteLine("Posted Time {0}", _dateTime.ToString("dd/MM/yyyy, HH:mm"));
            Console.WriteLine("\n");

        }

        public void UpVote()
        {
            _upVote++;
        }

        public void DownVote()
        {
            _downVote++;
        }

        public int DisplayCurrentVoteValue()
        {
            var currentVoteValue = _upVote - _downVote;
            if (currentVoteValue < 0)
            {
                return 0;
            }
            else
            {
                return currentVoteValue;
            }
        }
    }
}
