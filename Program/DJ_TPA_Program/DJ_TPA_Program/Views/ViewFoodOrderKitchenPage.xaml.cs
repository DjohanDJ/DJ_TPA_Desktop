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
    /// Interaction logic for ViewFoodOrderKitchenPage.xaml
    /// </summary>
    public partial class ViewFoodOrderKitchenPage : Page
    {
        public ViewFoodOrderKitchenPage()
        {
            InitializeComponent();
            DoLoadTableDataKitchen();
        }

        private void DoLoadTableDataKitchen()
        {
            var orderDetails = (from x in ConnectionController.GetInstance().OrderRequests
            select new
            {
                Id = x.Id,
                Waiter = x.EmployeeId,
                CustomerId = x.CustomerId,
                CustomerName = x.Customer.CustomerFullname,
                FoodName = x.OrderDetails.Where(y => y.Id.Equals(x.Id)).FirstOrDefault().Food.FoodName,
                FoodQuantity = x.OrderDetails.Where(y => y.Id.Equals(x.Id)).FirstOrDefault().Quantity,
                OrderTable = x.TableNumber,
                Status = x.OrderStatus
            }).Where(x => x.Status.Equals("Pending")).ToList();
            orderRequestTable.ItemsSource = orderDetails;
        }

        private void DoChangeOrderStatus(object sender, RoutedEventArgs e)
        {
            
            int id;
            Int32.TryParse(idText.Text, out id);
            RestaurantController.DoChangeToCooked(id);
            DoLoadTableDataKitchen();
            MessageBox.Show("Food cooked, Waiter take the food !");
        }
    }
}
