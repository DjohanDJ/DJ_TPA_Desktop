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

    public partial class ViewVisitorOrderPage : Page
    {

        public ViewVisitorOrderPage()
        {
            InitializeComponent();
            DoLoadTableDataDining();
        }

        private void DoLoadTableDataDining()
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
            }).Where(x => x.Status.Equals("Cooked")).ToList();
            orderRequestTable.ItemsSource = orderDetails;
        }
        
        private void DoChangeOrderStatus(object sender, RoutedEventArgs e)
        {
            int id;
            Int32.TryParse(idText.Text, out id);
            RestaurantController.DoChangeToEat(id);
            DoLoadTableDataDining();
            MessageBox.Show("Customer eat the food !");

        }
    }
}
