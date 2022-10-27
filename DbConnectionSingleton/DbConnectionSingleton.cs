using System.Configuration;
using System.Data.SqlClient;

namespace DbConnectionSingleton
{
    public class DbConnectionSingleton
    {
        private readonly SqlConnection sqlConnection = new SqlConnection(ConfigurationManager
            .ConnectionStrings["DefaultConnection"].ConnectionString);

        private static DbConnectionSingleton instance;

        private DbConnectionSingleton()
        {
        }

        public static DbConnectionSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbConnectionSingleton();
                }
                return instance;
            }
        }

    }
}
