using DJ_TPA_Program.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DJ_TPA_Program.Views
{

    public partial class RequestGrowthSalaryPage : Page
    {
        public RequestGrowthSalaryPage()
        {
            InitializeComponent();
            DoLoadTableData();
        }

        private void DoLoadTableData()
        {
            var employeeDetails = (from x in ConnectionController.GetInstance().Employees
            select new
            {
                Id = x.Id,
                EmployeeName = x.EmployeeFullname,
                EmployeeDepartment = x.Department.DepartmentName,
                EmployeeUsername = x.EmployeeUsername,
                EmployeePassword = x.EmployeePassword,
                EmployeeBanStatus = x.EmployeeBannedStatus,
                EmployeeEmail = x.EmployeeEmail,
                EmployeeGender = x.EmployeeGender,
                EmployeeSalary = x.EmployeeSalary
            }).ToList();
            employeeTable.ItemsSource = employeeDetails;
        }

        private void DoRequestSalary(object sender, RoutedEventArgs e)
        {
            int id, raiseSalary;
            Int32.TryParse(idText.Text, out id);
            Int32.TryParse(salaryText.Text, out raiseSalary);
            EmployeeController.DoRequestRaiseSalary(id, raiseSalary);
            HRDHomePage hrdHomePage = new HRDHomePage();
            this.NavigationService.Navigate(hrdHomePage);
            MessageBox.Show("Request Sent !");
        }

    }
}
