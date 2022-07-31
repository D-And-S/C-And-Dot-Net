using System;
using System.Collections.Generic;

namespace ExPolymorphismDBConnection
{
    public class DbCommand
    {
        private readonly string _sql;
        private readonly DbConnection _dbConnection;

        public DbCommand(DbConnection dbConnection, string sql)
        {
            _dbConnection = dbConnection ?? throw new Exception("Db Connection Cannot Be Null");
            _sql = sql ?? throw new Exception("Sql Cannot Be Null");
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("$ Executing: {0}", _sql);
            _dbConnection.Close();
        }
    }
}
