using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DJ_TPA_Program.Controllers
{
    class EmployeeController
    {

        public static void DoInsertEmployee(String[] employeeData)
        {
            Department department = DepartmentController.FindDepartmentByName(employeeData[7]);

            Employee employee = new Employee();
            employee.EmployeeUsername = employeeData[0];
            employee.EmployeeFullname = employeeData[1];
            employee.EmployeeEmail = employeeData[2];
            employee.EmployeePassword = employeeData[3];
            employee.EmployeePhoneNumber = employeeData[4];
            employee.EmployeeAddress = employeeData[5];
            employee.EmployeeGender = employeeData[6];
            employee.DepartmentId = department.Id;
            employee.EmployeeBannedStatus = "No";
            employee.EmployeeSalary = 4000000;
            

            ConnectionController.GetInstance().Employees.Add(employee);
            ConnectionController.GetInstance().SaveChanges();
        }

        public static String[] DoSearchEmployee(String username, String password)
        {
            String[] messages = { "", "" };

            Employee employee = ConnectionController.GetInstance().Employees.Where(x => x.EmployeeUsername.Equals(username) && x.EmployeePassword.Equals(password)).FirstOrDefault();

            if (employee == null)
            {
                messages[1] = "Invalid Credential";
                return messages;
            }
            if (employee.EmployeeBannedStatus.Equals("Yes"))
            {
                messages[1] = "You are banned";
                return messages;
            }

            messages[0] = employee.Id.ToString();

            return messages;
        }

        public static Employee DoSearchEmployee(int id)
        {
            Employee employee = ConnectionController.GetInstance().Employees.Where(x => x.Id.Equals(id)).FirstOrDefault();
            return employee;
        }

        public static void DoChangeEmployeeStatus(int id)
        {
            Employee employee = DoSearchEmployee(id);

            if (employee.EmployeeBannedStatus.Equals("No"))
            {
                employee.EmployeeBannedStatus = "Yes";
            }
            else
            {
                employee.EmployeeBannedStatus = "No";
            }

            ConnectionController.GetInstance().SaveChanges();

        }

        public static void DoAddFiringReason(String reason)
        {
            Firing firing = new Firing();

            firing.employeeId = ActiveUserController.GetActiveEmployee().Id;
            firing.fireDescription = reason;

            ConnectionController.GetInstance().Firings.Add(firing);
            ConnectionController.GetInstance().SaveChanges();
        }

        public static void DoRequestRaiseSalary(int targetId, int price)
        {
            RequestRaiseSalary raiseRequest = new RequestRaiseSalary();
            raiseRequest.EmployeeId = ActiveUserController.GetActiveEmployee().Id;
            raiseRequest.EmployeeRaisePrice = price;
            raiseRequest.EmployeeTargetId = targetId;
            raiseRequest.ResponseStatus = "Waiting";

            ConnectionController.GetInstance().RequestRaiseSalaries.Add(raiseRequest);
            ConnectionController.GetInstance().SaveChanges();
        }

        public static void DoRequestLeaving(String startTime, String endTime, String reason)
        {
            LeavingPermission leavingPermission = new LeavingPermission();
            leavingPermission.EmployeeId = ActiveUserController.GetActiveEmployee().Id;
            leavingPermission.Reason = reason;
            leavingPermission.StartDate = Convert.ToDateTime(startTime);
            leavingPermission.EndDate = Convert.ToDateTime(endTime);
            leavingPermission.ResponseStatus = "Waiting";

            ConnectionController.GetInstance().LeavingPermissions.Add(leavingPermission);
            ConnectionController.GetInstance().SaveChanges();
        }

        public static void DoChangePermissionStatus(int id, String response)
        {
            LeavingPermission leavingPermission = ConnectionController.GetInstance().LeavingPermissions.Where(x => x.Id.Equals(id)).FirstOrDefault();
            leavingPermission.ResponseStatus = response;
            ConnectionController.GetInstance().SaveChanges();
        }

        public static void DoRequestResign(String startTime, String reason)
        {
            ResignRequest resignPermission = new ResignRequest();
            resignPermission.EmployeeId = ActiveUserController.GetActiveEmployee().Id;
            resignPermission.ResignLetter = reason;
            resignPermission.ResignDate = Convert.ToDateTime(startTime);
            resignPermission.ResignResponse = "Waiting";

            ConnectionController.GetInstance().ResignRequests.Add(resignPermission);
            ConnectionController.GetInstance().SaveChanges();
        }

    }
}
