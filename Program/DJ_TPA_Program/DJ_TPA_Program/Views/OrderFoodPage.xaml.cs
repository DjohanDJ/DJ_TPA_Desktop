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

    public partial class OrderFoodPage : Page
    {
        public OrderFoodPage()
        {
            InitializeComponent();
            DoLoadTableData();
        }

        private void DoLoadTableData()
        {
            var orderDetails = (from x in ConnectionController.GetInstance().Tables
            select new
            {
                TableNumber = x.Id,
                TableStatus = x.TableStatus
            }).ToList();
            orderRequestTable.ItemsSource = orderDetails;
        }

        private void DoCreateOrder(object sender, RoutedEventArgs e)
        {
            int id;
            Int32.TryParse(idText.Text, out id);

            if (ConnectionController.GetInstance().Tables.Where(x => x.Id.Equals(id) && x.TableStatus.Equals("Unavailable")).FirstOrDefault() != null)
            {
                MessageBox.Show("Please order available table !");
            }
            else
            {
                CustomerController.DoOrderTable(idText.Text);
                MessageBox.Show("Table Ordered !");
                OrderFoodDetailPage detailPage = new OrderFoodDetailPage();
                this.NavigationService.Navigate(detailPage);
            }

        }

    }
}
