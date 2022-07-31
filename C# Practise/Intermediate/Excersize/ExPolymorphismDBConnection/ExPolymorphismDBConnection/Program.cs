using System;
using System.Collections.Generic;

namespace ExPolymorphismDBConnection
{

    class Program
    {
        static void Main(string[] args)
        {
            var sqlServer = new SqlServer("T SQL Server");
            var dbCommand = new DbCommand(sqlServer,"Drop data from user table");
            dbCommand.Execute();


        }
    }
}
