using System.Data;
using System.Data.SqlClient;

public class DapperContext
{
    private readonly string _connectionString;

    public DapperContext()
    {
        _connectionString = "Database=todo.db";
    }

    public IDbConnection CreateConnection()
        => new SqlConnection(_connectionString);
}
