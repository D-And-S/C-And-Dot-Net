using System;

namespace ExPolymorphismDBConnection
{
    public class OracleConnection:DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("Oracle Database Selected");
        }

        public override void Open()
        {
            Console.WriteLine("Connection Open");
        }
        public override void Close()
        {
            Console.WriteLine("Connection Close");
        }
    }
}
