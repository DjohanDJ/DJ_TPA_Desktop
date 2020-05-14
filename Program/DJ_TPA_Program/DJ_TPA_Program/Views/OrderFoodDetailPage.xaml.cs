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

    public partial class OrderFoodDetailPage : Page
    {
        public OrderFoodDetailPage()
        {
            InitializeComponent();
            DoLoadTableData();
        }

        private void DoLoadTableData()
        {
            var orderDetails = (from x in ConnectionController.GetInstance().Foods
            select new
            {
                FoodId = x.Id,
                FoodName = x.FoodName,
                FoodPrice = x.FoodPrice,
                FoodDescription = x.FoodDescription
            }).ToList();
            orderRequestTable.ItemsSource = orderDetails;
        }

        private void DoCreateOrder(object sender, RoutedEventArgs e)
        {
            CustomerController.DoOrderFood(idText.Text, quantity.Text);
            MessageBox.Show("Ordered !");
            GiveFeedbackPage feedbackPage = new GiveFeedbackPage();
            this.NavigationService.Navigate(feedbackPage);
        }

    }
}
