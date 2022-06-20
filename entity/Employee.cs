using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_employee_manage.entity
{
    public class Employee
    {
        // Khai bao cac object cua class employee
        public int emplId { get; set; }
        public string emplName { get; set; }
        public int projectId { get; set; }

        // Constructor
        public Employee() { }

        public Employee(int emplId, string emplName, int projectId)
        {
            this.emplId = emplId;
            this.emplName = emplName;
            this.projectId = projectId;
        }

        // reture ra chuoi string theo y cua minh (Override: ghi de)
        public override string ToString()
        {
            return "Employee ID: " + emplId + "\nEmployee Name: " + emplName + "\nProject ID: " + projectId;
        }
    }
}
