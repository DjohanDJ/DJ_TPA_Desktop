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
    
    public partial class FinancialHomePage : Page
    {
        public FinancialHomePage()
        {
            InitializeComponent();
            DoInitializeUser();
        }

        private void DoInitializeUser()
        {
            userLabelText.Text = "Welcome, " + ActiveUserController.GetActiveEmployee().EmployeeFullname;
        }

        private void DoViewAllFinanceRequest(object sender, RoutedEventArgs e)
        {
            ViewAllFinancialRequestPage viewAllFinancialRequestPage = new ViewAllFinancialRequestPage();
            this.NavigationService.Navigate(viewAllFinancialRequestPage);
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
