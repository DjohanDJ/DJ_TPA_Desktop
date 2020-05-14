using DJ_TPA_Program.Controllers;
using DJ_TPA_Program.Models;
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
    
    public partial class RegisterEmployeePage : Page
    {
        private List<Department> departments { get; set; }

        public RegisterEmployeePage()
        {
            InitializeComponent();
            DoFeedDepartmentComboBox();
        }

        private void DoRegisterButton(object sender, RoutedEventArgs e)
        {
            String[] employeeData = new String[10];

            employeeData[0] = usernameText.Text;
            employeeData[1] = fullnameText.Text;
            employeeData[2] = emailText.Text;
            employeeData[3] = passwordText.Password;
            employeeData[4] = phoneNumberText.Text;
            employeeData[5] = addressText.Text;
            employeeData[6] = genderBox.Text;
            employeeData[7] = departmentBox.Text;

            EmployeeController.DoInsertEmployee(employeeData);
            HRDHomePage hrdHomePage = new HRDHomePage();
            this.NavigationService.Navigate(hrdHomePage);
            MessageBox.Show("Register Success");
        }

        private void DoFeedDepartmentComboBox()
        {
            var department = ConnectionController.GetInstance().Departments.ToList();
            departments = department;
            DataContext = departments;
        }
    }
}
