using System.Collections.Generic;

namespace WorkingWIthConstructor
{
    public class Customer 
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id) : this()
        {
            Id = id;
        }

        public Customer(int id, string name): this(id)
        {
            Id = id;
            Name = name;
        }


    }
}
