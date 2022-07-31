namespace dotnetwithmongo.DataContext
{
    public class StudentStoreDatabaseSettings : IStudentStoreDatabaseSettings
    {
#nullable disable
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
