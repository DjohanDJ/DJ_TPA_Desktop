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
    public partial class ScheduleMaintainTimePage : Page
    {
        public ScheduleMaintainTimePage()
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
                RideStatus = x.RideStatus,
                RideMaintainStatus = x.RideMaintainStatus,
                RideTypeName = x.RideType.RideTypeName,
                RideSafetyName = x.RideSafety.RideSafetyName,
                RideForce = x.RideForce,
            }).ToList();
            rideTable.ItemsSource = rideDetails;
        }

        private void DoScheduleTime(object sender, RoutedEventArgs e)
        {
            int id;
            Int32.TryParse(idText.Text, out id);

            if (ConnectionController.GetInstance().Rides.Where(x => x.Id.Equals(id) && x.RideMaintainStatus.Equals("Yes")).FirstOrDefault() != null)
            {
                MessageBox.Show("Can's Schedule, Ride is under Maintain");
            }
            else
            {
                MessageBox.Show("Ride Maintenance Scheduled !");
            }

            MaintenanceController.DoScheduleMaintainTime(startTime.Text, endTime.Text, id);
            MaintenanceHomePage maintenanceHomePage = new MaintenanceHomePage();
            this.NavigationService.Navigate(maintenanceHomePage);
        }

    }
}
