using System.Collections;
using System.Linq;
using project_employee_manage.dao;
using project_employee_manage.connection;
using project_employee_manage.entity;

namespace project_employee_manage
{
    public class program
    {
        public static void Main(string[] args)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            ProjectDAO projectDAO = new ProjectDAO();
            List<Project> proList = projectDAO.getProjectData();
            List<Employee> empList = employeeDAO.getEmployeeData();

            var data = empList.Join(proList, emp => emp.projectId, pro => pro.proId, (emp, pro) => new { emp.emplName, pro.proName });

            foreach (var total in data)
            {
                Console.WriteLine("Employee name: " + total.emplName + "\nProject name: " + total.proName);
            }
        }
    }
}