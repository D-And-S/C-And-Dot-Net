using System;

namespace Dependency_Inversion_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    // high level module where business logic will be available
    class PayCalculator
    {
        private readonly IDbConnection _db;

        public PayCalculator(IDbConnection db)
        {
            _db = db;
        }
    }

    interface IDbConnection
    {
        void IDBConnection();
    }

    // low level module class
    class MySqlConnection : IDbConnection
    {
        public void IDBConnection()
        {
            throw new NotImplementedException();
        }
    }
}
