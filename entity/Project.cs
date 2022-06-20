using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_employee_manage.entity
{
    public class Project
    {
        public int proId { get; set; }
        public string proName { get; set; }

        public Project() { }

        public Project(int proId, string proName)
        {
            this.proId = proId;
            this.proName = proName;
        }

        public override string ToString()
        {
            return "Project Id: " + proId + "\nProjectName: " + proName;
        }
    }
}
