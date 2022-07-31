// without interface 
/*public class CustomerRepository{
    private readonly Database _database;

    public CustomerRepository(Database database)
    {
        _database = database;
    }   
}

public class Database {
    public void AddRow(string Table, string Value){}
}*/

public class CustomerRepository {  
    private readonly IDatabase database;  
    public CustomerRepository(IDatabase database) {  
        this.database = database;  
    }  
    public void Add(string CustomerName) {  
        database.AddRow("Customer", CustomerName);  
    }  
}  
public interface IDatabase {  
    void AddRow(string Table, string Value);  
}  
public class SqlDatabase: IDatabase {  
    public void AddRow(string Table, string Value) {  
        //Logic to add new customer in sql table  
    }  
}  
public class XMLDatabase: IDatabase {  
    public void AddRow(string Table, string Value) {  
        //Logic to add new customer in XML Document  
    }  
} 

