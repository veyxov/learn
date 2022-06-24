using Microsoft.Data.Sqlite;
using System.Data;

public class DapperContext
{
    private readonly string _connectionString;

    public DapperContext()
    {
        _connectionString = "Data Source=todo.db;";
    }

    public IDbConnection CreateConnection()
        => new SqliteConnection(_connectionString);
}
