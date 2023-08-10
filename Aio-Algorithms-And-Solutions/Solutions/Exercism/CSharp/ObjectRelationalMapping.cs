namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;
public class Orm: IDisposable
{
    private Database _database;
    public Orm(Database database) => this._database = database;
    public void Begin()
    {
        try
        {
            this._database.BeginTransaction();
        }
        catch 
        {
            this._database.Dispose();
        }
    }
    public void Write(string data)
    {
        try
        {
            this._database.Write(data); 
        }
        catch 
        {
            this._database.Dispose();
        }
    }
    public void Commit()
    {
        try
        {
            this._database.EndTransaction();
        }
        catch
        {
            this._database.Dispose();
        }
    }
    public void Dispose() => this._database.Dispose();
}

//  This is a fake database. It is not a real database. 
//  It is here to simulate a real database.
public class Database
{
    public void BeginTransaction()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public void Write(string data)
    {
        throw new NotImplementedException();
    }

    public void EndTransaction()
    {
        throw new NotImplementedException();
    }
}