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
    
    public partial class ViewAllFinancialRequestPage : Page
    {
        public ViewAllFinancialRequestPage()
        {
            InitializeComponent();
            DoLoadTableData();
        }

        private void DoLoadTableData()
        {
            var responseDetails = (from x in ConnectionController.GetInstance().HeaderFundRequests
            select new
            {
                Id = x.Id,
                MoneyAsk = x.PriceValue,
                EmployeeFrom = x.Employee.EmployeeFullname,
                DepartmentFrom = x.Employee.Department.DepartmentName,
                Status = x.ResponseStatus
            }).Where(x => x.Status.Equals("Waiting")).ToList();
            responseTable.ItemsSource = responseDetails;
        }

        private void DoResponse(object sender, RoutedEventArgs e)
        {
            int id;
            Int32.TryParse(idText.Text, out id);
            FundRequestController.DoResponse(id, responseText.Text);
            FinancialHomePage financialHomePage = new FinancialHomePage();
            this.NavigationService.Navigate(financialHomePage);
        }

    }
}
