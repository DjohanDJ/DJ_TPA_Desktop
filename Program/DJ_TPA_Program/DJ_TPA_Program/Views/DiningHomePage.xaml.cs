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
    /// <summary>
    /// Interaction logic for DiningHomePage.xaml
    /// </summary>
    public partial class DiningHomePage : Page
    {
        public DiningHomePage()
        {
            InitializeComponent();
            DoInitializeUser();
        }

        private void DoInitializeUser()
        {
            userLabelText.Text = "Welcome, " + ActiveUserController.GetActiveEmployee().EmployeeFullname;
        }

        private void DoCreateOrderRequest(object sender, RoutedEventArgs e)
        {
            CreateOrderRequestPage orderReqPage = new CreateOrderRequestPage();
            this.NavigationService.Navigate(orderReqPage);
        }

        private void DoViewVisitorOrder(object sender, RoutedEventArgs e)
        {
            ViewVisitorOrderPage orderReqPage = new ViewVisitorOrderPage();
            this.NavigationService.Navigate(orderReqPage);
        }

        private void DoViewVisitorTable(object sender, RoutedEventArgs e)
        {
            ViewVisitorTablePage orderReqPage = new ViewVisitorTablePage();
            this.NavigationService.Navigate(orderReqPage);
        }

        private void DoCreateVisitorBill(object sender, RoutedEventArgs e)
        {
            CreateVisitorBillPage billPage = new CreateVisitorBillPage();
            this.NavigationService.Navigate(billPage);
        }

        private void DoViewVisitorBill(object sender, RoutedEventArgs e)
        {
            ViewVisitorBillPage billPage = new ViewVisitorBillPage();
            this.NavigationService.Navigate(billPage);
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
