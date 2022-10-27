using System.Configuration;
using System.Data.SqlClient;

namespace DbConnSingleton
{
    public class DbConnectionSingleton
    {
        private readonly SqlConnection sqlConnection = new SqlConnection(ConfigurationManager
            .ConnectionStrings["DefaultConnection"].ConnectionString);

        private static DbConnectionSingleton instance;

        private static Dictionary<int, DbConnectionSingleton> DbConnectionThreadMap = new();

        private DbConnectionSingleton()
        {
        }

        public static DbConnectionSingleton Instance
        {
            get
            {
                var currentThreadId = Environment.CurrentManagedThreadId;
                if (!DbConnectionThreadMap.ContainsKey(currentThreadId))
                {
                    instance = new DbConnectionSingleton();
                    DbConnectionThreadMap.Add(currentThreadId, instance);
                }
                else
                {
                    instance = DbConnectionThreadMap[currentThreadId];
                }
                return instance;
            }
        }

        public int TreadId
        {
            get
            {
                return Environment.CurrentManagedThreadId;
            }
        }

    }
}
