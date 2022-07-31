namespace dotnetwithmongo.DataContext
{
    public interface IStudentStoreDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
