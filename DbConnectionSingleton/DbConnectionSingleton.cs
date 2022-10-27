using System.Data.SqlClient;

namespace DbConnectionSingleton
{
    public class DbConnectionSingleton
    {
        private readonly string connectionString = "Server=GLEBGOL;Database=FridgeDb;Trusted_Connection=True;";
        private readonly SqlConnection sqlConnection = new SqlConnection();
    }
}
