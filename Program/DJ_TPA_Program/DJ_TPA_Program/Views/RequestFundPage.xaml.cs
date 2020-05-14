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
    /// Interaction logic for RequestFundPage.xaml
    /// </summary>
    public partial class RequestFundPage : Page
    {

        private int money = -1;

        public RequestFundPage()
        {
            InitializeComponent();
            moneyPrice.Text = PurchaseRequestController.DoFeedMoney();
        }

        private void DoRequest(object sender, RoutedEventArgs e)
        {
            int money;
            Int32.TryParse(moneyPrice.Text, out money);

            if (!moneyPrice.Text.Equals(""))
            {
                RequestItemController.DoFundRequest(money, reasonDescText.Text, true);
                PurchaseHomePage purchaseHomePage = new PurchaseHomePage();
                this.NavigationService.Navigate(purchaseHomePage);
            }
            else
            {
                RequestItemController.DoFundRequest(money, reasonDescText.Text, false);
                RequestItemPage requestItemPage = new RequestItemPage();
                this.NavigationService.Navigate(requestItemPage);
            }
            MessageBox.Show("Your request has been sent !");
        }

    }
}
