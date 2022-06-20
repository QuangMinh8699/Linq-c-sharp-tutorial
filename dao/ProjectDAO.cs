using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using project_employee_manage.connection;
using project_employee_manage.entity;

namespace project_employee_manage.dao
{
    public class ProjectDAO
    {
        public List<Project> getProjectData()
        {
            ConnectDb connectDb = new ConnectDb();
            SqlConnection connection = connectDb.GetSqlConnection();
            string query = "SELECT * FROM project";
            List<Project> list = new List<Project>();
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Project project = new Project();
                project.proId = Convert.ToInt32(reader[0]);
                project.proName = Convert.ToString(reader[1]);
                list.Add(project);
            }

            connection.Close();
            return list;
        }
    }
}
