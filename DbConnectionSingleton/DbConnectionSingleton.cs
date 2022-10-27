using System.Configuration;
using System.Data.SqlClient;

namespace DbConnectionSingleton
{
    public class DbConnectionSingleton
    {
        private readonly SqlConnection sqlConnection = new SqlConnection(ConfigurationManager
            .ConnectionStrings["DefaultConnection"].ConnectionString);

        private static volatile DbConnectionSingleton instance;
        private static object syncRoot = new Object();

        private DbConnectionSingleton()
        {
        }

        public static DbConnectionSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance ??= new DbConnectionSingleton();
                    }
                }
                return instance;
            }
        }

    }
}
