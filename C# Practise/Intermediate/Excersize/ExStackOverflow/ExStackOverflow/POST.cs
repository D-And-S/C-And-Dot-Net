using System;

namespace ExStackOverflow
{
    public class POST
    {
        private string _title;
        private string _description;
        private int _upVote;
        private int _downVote;
        private DateTime _dateTime;

        public void PostData(string title, string description)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
                throw new OperationCanceledException("Title and Descripton Should be Enter");

            _title = title;
            _description = description;
            _dateTime = DateTime.Now;

            Console.WriteLine("Title: {0}",title);
            Console.WriteLine("\n");
            Console.WriteLine("Description: {0}",description);
            Console.WriteLine("\n");
            Console.WriteLine("Posted Time { 0}", _dateTime);

        }

        public void UpVote(string yes)
        {
            yes.ToLower();
            while (true)
            {
                Console.WriteLine("Do you want to upvote it, Y/N");
                if (yes == "y")
                {
                    _upVote++;
                }else
                {
                    break;
                }
            }          
        }

        public void DownVote(string yes)
        {           
            yes.ToLower();
            while (true)
            {
                Console.WriteLine("Do you want to upvote it, Y/N");
                if (yes == "y")
                {
                    _downVote++;
                }
                else
                {
                    break;
                }
            }
            
        }

        public int DisplayCurrentVoteValue()
        {
            var currentVoteValue = _upVote - _downVote;
            if (currentVoteValue < 0)
            {
                return 0;
            }else
            {
                return currentVoteValue;
            }
        }
    }
}
