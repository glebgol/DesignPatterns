using System.Configuration;
using System.Data.SqlClient;

namespace DbConnectionSingleton
{
    public class DbConnectionSingleton
    {
        private readonly SqlConnection sqlConnection = new SqlConnection(ConfigurationManager
            .ConnectionStrings["DefaultConnection"].ConnectionString);

        private static volatile DbConnectionSingleton instance;

        private static Dictionary<int, DbConnectionSingleton> DbConnectionThreadMap = new();

        private DbConnectionSingleton()
        {
        }

        public static DbConnectionSingleton Instance
        {
            get
            {
                if (!DbConnectionThreadMap.ContainsKey(Thread.CurrentThread.ManagedThreadId))
                {
                    instance = new DbConnectionSingleton();
                    DbConnectionThreadMap.Add(Thread.CurrentThread.ManagedThreadId, instance);
                }
                else
                {
                    instance = DbConnectionThreadMap[Thread.CurrentThread.ManagedThreadId];
                }
                return instance;
            }
        }

    }
}
