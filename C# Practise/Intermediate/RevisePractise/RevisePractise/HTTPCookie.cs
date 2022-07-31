using System;
using System.Collections.Generic;

namespace RevisePractise
{
    public class HTTPCookie
    {
        // for the purpose of learn indexers
        // whenever i have list of object and i want to look them by a key 
        // as opposed to an index
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        public DateTime Expiry { get; set; }

        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set { _dictionary[key] = value; }
        }
    }
}
