using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace project_employee_manage.connection
{
    public class ConnectDb
    {
        public SqlConnection GetSqlConnection()
        {
            string query = "Server = CARAMEL14\\SQLEXPRESS;" + 
                "Initial Catalog = minhxinhtrai; Integrated Security= SSPI";
            SqlConnection conn = new SqlConnection(query);

            return conn;
        }
    }
}
