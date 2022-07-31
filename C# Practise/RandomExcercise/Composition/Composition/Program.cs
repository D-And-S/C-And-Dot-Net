using System;

namespace Composition
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void InstallerLog()
        {
            _logger.Log("Instlaler Migrating blah blah");
        }
    }
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void DatabaseLog()
        {
            _logger.Log("We are Migrating blah blah bal");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());
            var installer = new Installer(new Logger());

            dbMigrator.DatabaseLog();
            installer.InstallerLog();
        }
    }
}
