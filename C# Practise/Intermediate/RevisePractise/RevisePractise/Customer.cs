using System;
using System.Collections.Generic;

namespace RevisePractise
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();
        public Customer()
        {

        }
        public Customer(int id) : this()
        {
            Id = id;
        }

        public Customer(int id, string name):this(id)
        {
            Id = id;
            Name = name;
        }

        public void Promote()
        {
            // what if initialize order class by mistake.
            //Orders = new List<Order>();
        }

    }
}
