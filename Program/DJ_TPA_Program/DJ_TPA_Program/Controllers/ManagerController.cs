using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class ManagerController
    {

        public static void DoChangeStatus(int id, string status)
        {
            HeaderResponse headerResponse = ConnectionController.GetInstance().HeaderResponses.Where(x => x.Id.Equals(id)).FirstOrDefault();
            headerResponse.ResponseStatus = status;
            ConnectionController.GetInstance().SaveChanges();
        }

        public static void DoChangeSalary(int id, string status)
        {
            RequestRaiseSalary reqSalary = ConnectionController.GetInstance().RequestRaiseSalaries.Where(x => x.Id.Equals(id)).FirstOrDefault(); ;
            reqSalary.ResponseStatus = status;
            ConnectionController.GetInstance().SaveChanges();

            if (status.Equals("Approved"))
            {
                Employee employee = ConnectionController.GetInstance().Employees.Where(x => x.Id.Equals(reqSalary.EmployeeTargetId)).FirstOrDefault();
                employee.EmployeeSalary += reqSalary.EmployeeRaisePrice;
                ConnectionController.GetInstance().SaveChanges();
            }
        }

        public static void DoChangeResignStatus(int id, string status)
        {
            ResignRequest resignReq = ConnectionController.GetInstance().ResignRequests.Where(x => x.Id.Equals(id)).FirstOrDefault();
            resignReq.ResignResponse = status;
            ConnectionController.GetInstance().SaveChanges();
        }

    }
}
