using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_GUI2
{
    class Database
    {
        public static SqlConnection ConnectDB()
        {
            string connString = @"Server=DESKTOP-RTQVKPL;Database=demo_m_sp21; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
