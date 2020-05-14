using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class LoginController
    {

        public static String[] DoUserLogin(String username, String password)
        {
            return EmployeeController.DoSearchEmployee(username, password);
        }

        public static String[] DoCustomerLogin(String username, String password)
        {
            return CustomerController.DoSearchCustomer(username, password);
        }

        public static void DoFeedActiveEmployee(int id)
        {
            ActiveUserController.SetActiveEmployee(EmployeeController.DoSearchEmployee(id));
        }

        public static void DoFeedActiveCustomer(int id)
        {
            ActiveUserController.SetActiveCustomer(CustomerController.DoSearchCustomer(id));
        }

    }
}
