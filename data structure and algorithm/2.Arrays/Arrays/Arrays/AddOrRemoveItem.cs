using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class AddOrRemoveItem
    {
        public static void AddItem()
        {
            var number = new List<int>(3);
            number.Add(1);
            number.Add(2);
            number.Add(4);
            number.Add(5);

            foreach (var item in number)
            {
                Console.WriteLine(item + " ");
            }
        }
        
        public static void RemoveItem()
        {
            var user = new List<string>();
            user.Add("mh");
            user.Add("ratul");
            user.Add("antor");
            user.Add("hossain");

            user.RemoveAt(3);

            foreach (var item in user)
            {
                Console.WriteLine(item);
            }
        }
    }
}
