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
    public partial class ChangeProgressStatusPage : Page
    {
        public ChangeProgressStatusPage()
        {
            InitializeComponent();
            DoLoadTableData();
        }

        private void DoLoadTableData()
        {
            var rideDetails = (from x in ConnectionController.GetInstance().HeaderConstructions
            select new
            {
                Id = x.Id,
                RideName = x.Ride.RideName,
                RideDurabilityCheckEachWeek = x.Ride.RideDurabilityCheckPerWeek,
                RideStatus = x.Ride.RideStatus,
                RideMaintainStatus = x.Ride.RideMaintainStatus,
                RideTypeName = x.Ride.RideType.RideTypeName,
                RideSafetyName = x.Ride.RideSafety.RideSafetyName,
                RideForce = x.Ride.RideForce,
            }).Where(x => x.RideStatus.Equals("On Going")).ToList();
            rideTable.ItemsSource = rideDetails;
        }

        private void DoChangeStatus(object sender, RoutedEventArgs e)
        {
            int id;
            Int32.TryParse(idText.Text, out id);
            ResponseController.DoChangeStatus(id);
            CreativeHomePage creativeHomePage = new CreativeHomePage();
            this.NavigationService.Navigate(creativeHomePage);
            MessageBox.Show("Status Updated!");
        }
    }
}
