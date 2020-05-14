using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class DepartmentController
    {

        public static Department FindDepartmentByName(String departmentName)
        {
            Department department;
            department = ConnectionController.GetInstance().Departments.Where(x => x.DepartmentName.Equals(departmentName)).FirstOrDefault();
            return department;
        }

    }
}
