using System;

namespace ExPolymorphismDBConnection
{
    public class SqlServer : DbConnection
    {
        public SqlServer(string connectionString) : base(connectionString)
        {
            Console.WriteLine("SQL Server Selected");
        }

        public override void Open()
        {
            Console.WriteLine("SQL Server Open");
        }

        public override void Close()
        {
            Console.WriteLine("SQL Server CLose");
        }
    }
}
