using System;

namespace MethodChainingDemo
{
    // return type must be own classes
    internal class Program
    {
        static void Main(string[] args)
        {
            var sd = new StringDeveloper();
            sd.AddText("Hello").AddText(" World").AddText(" beautiful").RemoveCharFromLast().AddText(" Testing");

            Console.WriteLine(sd.getText());
        }
    }

    public class StringDeveloper
    {
        private string _content = "";

        public StringDeveloper AddText(string a)
        {
            _content += a;
            return this;
        }

        public StringDeveloper RemoveCharFromLast()
        {
            _content = _content.Remove(_content.Length - 1, 1);
            return this;
        }

        public string getText()
        {
            return _content;
        }
    }
}
