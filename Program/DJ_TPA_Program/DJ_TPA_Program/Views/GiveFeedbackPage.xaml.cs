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
    
    public partial class GiveFeedbackPage : Page
    {
        public GiveFeedbackPage()
        {
            InitializeComponent();
        }

        private void DoLoadTableData()
        {
            var orderDetails = (from x in ConnectionController.GetInstance().OrderRequests
            select new
            {
                Id = x.Id,
                CustomerId = x.CustomerId,
                CustomerName = x.Customer.CustomerFullname,
                FoodName = x.OrderDetails.Where(y => y.Id.Equals(x.Id)).FirstOrDefault().Food.FoodName,
                FoodQuantity = x.OrderDetails.Where(y => y.Id.Equals(x.Id)).FirstOrDefault().Quantity,
                OrderTable = x.TableNumber,
                TotalPrice = x.OrderDetails.Where(y => y.Id.Equals(x.Id)).FirstOrDefault().Quantity * x.OrderDetails.Where(y => y.Id.Equals(x.Id)).FirstOrDefault().Food.FoodPrice,
                Status = x.OrderStatus
            }).Where(x => x.Status.Equals("Done")).ToList();
            orderRequestTable.ItemsSource = orderDetails;
        }

        private void DoGiveFeedback(object sender, RoutedEventArgs e)
        {
            CustomerController.DoGiveFeedback(idText.Text, quantity.Text);
            MessageBox.Show("Thankyou for your feedback !");
            CustomerHomePage custPage = new CustomerHomePage();
            this.NavigationService.Navigate(custPage);
        }

    }
}
