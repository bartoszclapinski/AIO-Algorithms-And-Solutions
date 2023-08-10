namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;
public class OrmInOneGo
{
    // This is a fake database class that is used to demonstrate the concept of ORM in one go.
    // Class is defined in ObjectRelationalMapping.cs
    private Database _database;
    public OrmInOneGo(Database database) => _database = database;
    public void Write(string data)
    {
        using var database = _database;
        database.BeginTransaction();
        database.Write(data);
        database.EndTransaction();
    }
    public bool WriteSafely(string data)
    {        
        try 
        {
            Write(data);
            return true;
        } 
        catch 
        {            
            return false;
        }        
    }
    
}