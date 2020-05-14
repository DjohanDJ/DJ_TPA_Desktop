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
    /// Interaction logic for RequestPurchasePage.xaml
    /// </summary>
    public partial class RequestPurchasePage : Page
    {
        public RequestPurchasePage()
        {
            InitializeComponent();
        }

        private void DoRequest(object sender, RoutedEventArgs e)
        {
            int id;
            Int32.TryParse(itemQtyText.Text, out id);
            RequestItemController.DoPurchaseRequest(itemNameText.Text, itemDescText.Text, id);
            RequestItemPage requestItemPage = new RequestItemPage();
            this.NavigationService.Navigate(requestItemPage);
            MessageBox.Show("Your request has been sent !");
        }

    }
}
