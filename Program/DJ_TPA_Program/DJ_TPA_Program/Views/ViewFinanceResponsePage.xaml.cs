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
    
    public partial class ViewFinanceResponsePage : Page
    {
        public ViewFinanceResponsePage()
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
                PriceRequested = x.PriceValue,
                Reason = x.Description,
                RequestBy = x.Employee.EmployeeFullname,
                DepartmentFrom = x.Employee.Department.DepartmentName,
                ResponseStatus = x.ResponseStatus
            }).ToList();
            responseTable.ItemsSource = responseDetails;
        }

        private void DoBuyMaterial(object sender, RoutedEventArgs e)
        {
            int id;
            Int32.TryParse(idText.Text, out id);

            if (ConnectionController.GetInstance().HeaderFundRequests.Where(x => x.Id.Equals(id) && x.ResponseStatus.Equals("Approved")).FirstOrDefault() != null)
            {
                PurchaseRequestController.DoBuyMaterial(id);
                MessageBox.Show("Material Bought");
            }
            else
            {
                MessageBox.Show("Sorry, you can only buy approved material");
            }
            
            PurchaseHomePage purchaseHomePage = new PurchaseHomePage();
            this.NavigationService.Navigate(purchaseHomePage);
        }

    }
}
