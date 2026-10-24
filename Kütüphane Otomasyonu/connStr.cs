using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Kütüphane_Otomasyonu
{
    internal class connStr
    {
        string connString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlConnection.ClearPool(conn);
            return conn;
        }
    }
}
