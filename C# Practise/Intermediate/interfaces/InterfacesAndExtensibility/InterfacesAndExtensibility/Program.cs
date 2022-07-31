namespace InterfacesAndExtensibility
{
    class Program
    {
       static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("D:\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
