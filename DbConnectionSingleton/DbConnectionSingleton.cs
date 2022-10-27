using System.Configuration;
using System.Data.SqlClient;

namespace DbConnectionSingleton
{
    public class DbConnectionSingleton
    {
        private readonly SqlConnection sqlConnection = new SqlConnection(ConfigurationManager
            .ConnectionStrings["DefaultConnection"].ConnectionString);


    }
}
