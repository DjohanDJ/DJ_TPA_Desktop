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

    public partial class HRDHomePage : Page
    {
        public HRDHomePage()
        {
            InitializeComponent();
            DoInitializeUser();
        }

        private void DoInitializeUser()
        {
            userLabelText.Text = "Welcome, " + ActiveUserController.GetActiveEmployee().EmployeeFullname;
        }

        private void DoViewAllEmployeeData(object sender, RoutedEventArgs e)
        {
            ViewAllEmployeePage viewAllEmpPage = new ViewAllEmployeePage();
            this.NavigationService.Navigate(viewAllEmpPage);
        }

        private void DoRequestGrowthSalary(object sender, RoutedEventArgs e)
        {
            RequestGrowthSalaryPage raiseSalaryPage = new RequestGrowthSalaryPage();
            this.NavigationService.Navigate(raiseSalaryPage);
        }

        private void DoSendFundRequest(object sender, RoutedEventArgs e)
        {
            RequestFundPage reqFundPage = new RequestFundPage();
            this.NavigationService.Navigate(reqFundPage);
        }

        private void DoCreateFiringReason(object sender, RoutedEventArgs e)
        {
            FiringReasonPage firingPage = new FiringReasonPage();
            this.NavigationService.Navigate(firingPage);
        }

        private void DoViewAllEmployeeRequestForLeaving(object sender, RoutedEventArgs e)
        {
            ViewAllEmployeeLeavingRequestPage leavingRequest = new ViewAllEmployeeLeavingRequestPage();
            this.NavigationService.Navigate(leavingRequest);
        }

        private void DoRegisterEmployee(object sender, RoutedEventArgs e)
        {
            RegisterEmployeePage registerEmployeePage = new RegisterEmployeePage();
            this.NavigationService.Navigate(registerEmployeePage);
        }

        private void DoLeavingPermission(object sender, RoutedEventArgs e)
        {
            RequestLeavingPermissionPage reqLeaving = new RequestLeavingPermissionPage();
            this.NavigationService.Navigate(reqLeaving);
        }

        private void DoResignLetter(object sender, RoutedEventArgs e)
        {
            CreateResignLetterPage resignPage = new CreateResignLetterPage();
            this.NavigationService.Navigate(resignPage);
        }

        private void DoLogout(object sender, RoutedEventArgs e)
        {
            ActiveUserController.SetActiveEmployee(null);
            LoginPage loginPage = new LoginPage();
            this.NavigationService.Navigate(loginPage);
        }

    }
}
