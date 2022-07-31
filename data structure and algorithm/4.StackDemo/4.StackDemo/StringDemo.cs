using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.StackDemo
{
    public class StringDemo
    {
        private readonly List<char> leftBracket = new List<char>(new[] { '(', '{', '<', '[' });
        private readonly List<char> rightBracket = new List<char>(new[] { ')', '}', '>', ']' });

        public void StringReverse(string data)
        {
            for (var i = data.Length; i > 0; i--)
            {
                Console.Write(data[i - 1]);
            }
        }

        //Create an Balance string by using stack
        public bool BalanceString(string str)
        {
            var stack = new Stack<char>();

            foreach (var ch in str)
            {
                if (IsLeft(ch))
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count == 0) return false;

                    if (IsRight(ch))
                    {
                        stack.Pop();
                    }
                }
            }

            if (stack.Count > 0) return false;

            return true;
        }

        public bool IsLeft(char ch)
        {
            return leftBracket.Contains(ch);
        }

        public bool IsRight(char ch)
        {
           return rightBracket.Contains(ch);
        }

    }
}
