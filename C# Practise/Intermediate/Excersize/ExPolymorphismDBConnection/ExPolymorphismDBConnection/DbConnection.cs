using System;
using System.Threading;

namespace ExPolymorphismDBConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public DateTime Timeout  { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("Connection String Can't be Null");

            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();


    }
}
