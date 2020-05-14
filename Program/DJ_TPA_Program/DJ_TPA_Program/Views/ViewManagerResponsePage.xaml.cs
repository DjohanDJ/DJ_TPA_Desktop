using DJ_TPA_Program.Controllers;
using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
    
    public partial class ViewManagerResponsePage : Page
    {
        public ViewManagerResponsePage()
        {
            InitializeComponent();
            DoLoadTableData();
        }

        private void DoLoadTableData()
        {
            var responseDetails = (from x in ConnectionController.GetInstance().HeaderResponses select new {
                Id = x.Id,
                RideName = x.Ride.RideName,
                ResponseStatus = x.ResponseStatus
            }).Where(x => x.ResponseStatus.Equals("Approved") || x.ResponseStatus.Equals("Declined")).ToList();
            managerResponseTable.ItemsSource = responseDetails;
        }

        private void DoSendToConstructionDepartment(object sender, RoutedEventArgs e)
        {
            int id;
            Int32.TryParse(idText.Text, out id);

            if (ConnectionController.GetInstance().HeaderResponses.Where(x => x.ResponseStatus.Equals("Declined") && x.Id.Equals(id)).FirstOrDefault() != null)
            {
                MessageBox.Show("You can only sent Approved File!");
            }
            else
            {
                ResponseController.DoSendToConstructionDepartment(id);
                MessageBox.Show("File Sent to Construction Department!");
            }

            CreativeHomePage creativeHomePage = new CreativeHomePage();
            this.NavigationService.Navigate(creativeHomePage);
        }
        
    }
}
