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
    
    public partial class RequestItemPage : Page
    {
        public RequestItemPage()
        {
            InitializeComponent();
        }

        private void DoPurchaseRequest(object sender, RoutedEventArgs e)
        {
            RequestPurchasePage purchaseReqPage = new RequestPurchasePage();
            this.NavigationService.Navigate(purchaseReqPage);
        }

        private void DoFundRequest(object sender, RoutedEventArgs e)
        {
            RequestFundPage fundReqPage = new RequestFundPage();
            this.NavigationService.Navigate(fundReqPage);
        }

    }
}
