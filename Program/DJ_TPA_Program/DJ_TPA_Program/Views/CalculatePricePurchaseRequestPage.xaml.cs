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
    
    public partial class CalculatePricePurchaseRequestPage : Page
    {
        public CalculatePricePurchaseRequestPage()
        {
            InitializeComponent();
            DoLoadTableData();
        }

        private void DoLoadTableData()
        {
            var requestDetails = (from x in ConnectionController.GetInstance().HeaderPurchaseRequests
            select new
            {
                Id = x.Id,
                Item = x.ItemPiece.ItemName,
                ItemQuantity = x.Quantity,
                ItemDescription = x.ItemPiece.ItemDescription,
                RequestBy = x.Employee.EmployeeFullname,
                DepartmentFrom = x.Employee.Department.DepartmentName,
                Status = x.ResponseStatus
            }).Where(x => x.Status.Equals("Waiting")).ToList();
            requestTable.ItemsSource = requestDetails;
        }

        private void DoFundRequest(object sender, RoutedEventArgs e)
        {
            int id, money;
            Int32.TryParse(idText.Text, out id);
            Int32.TryParse(moneyText.Text, out money);
            PurchaseRequestController.DoFeedItemMoney(id, money);
            PurchaseRequestController.DoSetMoney(money);
            RequestFundPage fundRequestPage = new RequestFundPage();
            this.NavigationService.Navigate(fundRequestPage);
        }

    }
}
