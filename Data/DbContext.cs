using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshopsystem.Data
{
    public class DbContext
    {
        protected SqlConnection Connection => DbConnectionSingleton.Instance;
    }
}
