using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    internal abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract int CalculateBonus(int Salary);

    }

    class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int id, string name) : base(id, name)
        {
        }

        public override int CalculateBonus(int Salary)
        {
            return Salary * 10;
        }
    }

    class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(int id, string name) : base(id, name)
        {
        }

        public override int CalculateBonus(int Salary)
        {
            return Salary * 5;
        }
    }
}
