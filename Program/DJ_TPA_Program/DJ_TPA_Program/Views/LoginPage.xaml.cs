using DJ_TPA_Program.Controllers;
using DJ_TPA_Program.Models;
using DJ_TPA_Program.Views.FactoryMethod;
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
    public partial class LoginPage : Page
    {
        public object TestDB { get; private set; }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void DoLoginButton(object sender, RoutedEventArgs e)
        {
            String[] messages = LoginController.DoUserLogin(usernameText.Text, passwordText.Password);
            
            if (messages[0].Equals(""))
            {
                messages = LoginController.DoCustomerLogin(usernameText.Text, passwordText.Password);
                if (messages[0].Equals(""))
                {
                    errorLabelText.Text = messages[1];
                    return;
                }
                else
                {
                    int id;
                    Int32.TryParse(messages[0], out id);
                    LoginController.DoFeedActiveCustomer(id);
                    CustomerHomePage customerPage = new CustomerHomePage();
                    this.NavigationService.Navigate(customerPage);
                    MessageBox.Show($"Login Success As Customer {ActiveUserController.GetActiveCustomer().CustomerFullname}");
                }
            }
            else
            {
                int id;
                Int32.TryParse(messages[0], out id);
                LoginController.DoFeedActiveEmployee(id);
                if (ActiveUserController.GetActiveEmployee().DepartmentId == 2)
                {
                    //CreativeHomePage creativeHomePage = new CreativeHomePage();
                    this.NavigationService.Navigate(PageFactory.GetInstance("Creative"));
                }
                else if (ActiveUserController.GetActiveEmployee().DepartmentId == 3)
                {
                    //MaintenanceHomePage maintenanceHomePage = new MaintenanceHomePage();
                    this.NavigationService.Navigate(PageFactory.GetInstance("Maintenance"));
                }
                else if (ActiveUserController.GetActiveEmployee().DepartmentId == 4)
                {
                    //ConstructionHomePage constructionHomePage = new ConstructionHomePage();
                    this.NavigationService.Navigate(PageFactory.GetInstance("Construction"));
                }
                else if (ActiveUserController.GetActiveEmployee().DepartmentId == 5)
                {
                    //KitchenHomePage kitchenHomePage = new KitchenHomePage();
                    this.NavigationService.Navigate(PageFactory.GetInstance("Kitchen"));
                }
                else if (ActiveUserController.GetActiveEmployee().DepartmentId == 6)
                {
                    //DiningHomePage diningHomePage = new DiningHomePage();
                    this.NavigationService.Navigate(PageFactory.GetInstance("Dining"));
                }
                else if (ActiveUserController.GetActiveEmployee().DepartmentId == 7)
                {
                    //PurchaseHomePage purchaseHomePage = new PurchaseHomePage();
                    this.NavigationService.Navigate(PageFactory.GetInstance("Purchase"));
                }
                else if (ActiveUserController.GetActiveEmployee().DepartmentId == 10)
                {
                    //SalesMarketingHomePage salesHomePage = new SalesMarketingHomePage();
                    this.NavigationService.Navigate(PageFactory.GetInstance("Sales"));
                }
                else if (ActiveUserController.GetActiveEmployee().DepartmentId == 11)
                {
                    //HRDHomePage hrdHomePage = new HRDHomePage();
                    this.NavigationService.Navigate(PageFactory.GetInstance("HRD"));
                }
                else if (ActiveUserController.GetActiveEmployee().DepartmentId == 12)
                {
                    //FinancialHomePage financialHomePage = new FinancialHomePage();
                    this.NavigationService.Navigate(PageFactory.GetInstance("Finance"));
                }
                else if (ActiveUserController.GetActiveEmployee().DepartmentId == 13)
                {
                    //ManagerHomePage managerHomePage = new ManagerHomePage();
                    this.NavigationService.Navigate(PageFactory.GetInstance("Manager"));
                }
                MessageBox.Show($"Login Success As {ActiveUserController.GetActiveEmployee().EmployeeFullname}");
            }
        }

        private void DoRegisterCustomer(object sender, RoutedEventArgs e)
        {
            RegisterCustomerPage registerCustomerPage = new RegisterCustomerPage();
            this.NavigationService.Navigate(registerCustomerPage);
        }

    }
}
