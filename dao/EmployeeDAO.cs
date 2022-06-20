using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using project_employee_manage.entity;
using project_employee_manage.connection;

namespace project_employee_manage.dao
{
    public class EmployeeDAO
    {
        // khoi tao method dang list Employee
        public List<Employee> getEmployeeData()
        {
            ConnectDb connectDb = new ConnectDb();
            SqlConnection sqlConnection = connectDb.GetSqlConnection();
            // khoi tao list moi dang employee
            List<Employee> list = new List<Employee>();

            // khoi tao cau lenh truy van trong sql
            string query = "SELECT * FROM employee";

            SqlCommand cmd = new SqlCommand(query,sqlConnection);

            // khoi dong sql 
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // dung vong lap de doc mang
            while (reader.Read())
            {
                Employee employee = new Employee();
                int emplId = Convert.ToInt32(reader[0]);
                string emplName =  Convert.ToString(reader[1]);
                int projectId = Convert.ToInt32(reader[2]);
                employee.emplId = emplId;
                employee.emplName = emplName;
                employee.projectId = projectId;
                list.Add(employee);
            }
            sqlConnection.Close();
            return list;
        }
    }
}
