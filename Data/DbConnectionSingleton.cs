using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshopsystem.Data
{
    public sealed class DbConnectionSingleton
    {
        private static SqlConnection _instance;
        private static readonly object _lock = new object();

        private DbConnectionSingleton() { }

        public static SqlConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        string connStr = ConfigurationManager
                            .ConnectionStrings["BookShopDB"]
                            .ConnectionString;

                        _instance = new SqlConnection(connStr);
                    }

                    return _instance;
                }
            }
        }
    }
}
