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

    public partial class ViewVisitorTablePage : Page
    {
        public ViewVisitorTablePage()
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

    }
}
