using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

public class SqlGateway
{
    private const string connectionString = "server=(local)\\SQLExpress;database=Northwind;integrated Security=SSPI;";
    private static SqlConnection sqlConnection = InitializeSql();
   
    public bool Update()
    {
        using(sqlConnection)
        {

        }
        throw new NotImplementedException();
    }

    public bool Insert()
    {
        using (sqlConnection)
        {

        }
        throw new NotImplementedException();
    }

    public List<LabSystem> RetrieveAllLabSystems()
    {
        using (sqlConnection)
        {

        }
        return new List<LabSystem>();
    }

    public List<User> RetrieveAllUsers()
    {
        using (sqlConnection)
        {

        }
        return new List<User>();
    }

    private static SqlConnection InitializeSql()
    {
        if (sqlConnection == null)
        {
          return new SqlConnection(connectionString);
        }

        return sqlConnection;
    }

}