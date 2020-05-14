using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class ActiveUserController
    {

        private static Employee activeEmployee;
        private static Customer activeCustomer;

        public static Employee GetActiveEmployee()
        {
            return activeEmployee;
        }

        public static void SetActiveEmployee(Employee employee)
        {
            activeEmployee = employee;
        }

        public static Customer GetActiveCustomer()
        {
            return activeCustomer;
        }

        public static void SetActiveCustomer(Customer customer)
        {
            activeCustomer = customer;
        }

    }
}
