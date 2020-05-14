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
    
    public partial class ChangeCurrentRidePage : Page
    {
        public ChangeCurrentRidePage()
        {
            InitializeComponent();
            DoLoadTableData();
        }

        private void DoLoadTableData()
        {
            var rideDetails = (from x in ConnectionController.GetInstance().Rides
            select new
            {
                Id = x.Id,
                RideName = x.RideName,
                RideDurabilityCheckEachWeek = x.RideDurabilityCheckPerWeek,
                RideStatus = x.RideStatus,
                RideMaintainStatus = x.RideMaintainStatus,
                RideTypeName = x.RideType.RideTypeName,
                RideSafetyName = x.RideSafety.RideSafetyName,
                RideForce = x.RideForce,
            }).ToList();
            rideTable.ItemsSource = rideDetails;
        }

        private void DoNextButton(object sender, RoutedEventArgs e)
        {
            ChangeCurrentRideTypePage changeCurrentRideTypePage = new ChangeCurrentRideTypePage();
            this.NavigationService.Navigate(changeCurrentRideTypePage);
            int id;
            Int32.TryParse(idText.Text, out id);
            RideCreationController.DoPrepareRideChange(id, rideNameText.Text, durabilityBox.Text, quantityBox.Text);
        }
    }
}
