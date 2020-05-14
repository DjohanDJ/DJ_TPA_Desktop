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

    public partial class ChangeMaintainStatusPage : Page
    {
        public ChangeMaintainStatusPage()
        {
            InitializeComponent();
            DoLoadTableData();
        }

        private void DoLoadTableData()
        {
            var scheduleDetails = (from x in ConnectionController.GetInstance().HeaderMaintenances
            select new
            {
                Id = x.Id,
                RideName = x.Ride.RideName,
                StartDate = x.StartTime,
                EndDate = x.EndTime,
                MaintenanceStatus = x.Ride.RideMaintainStatus,
                EmployeeResponsbility = x.Employee.EmployeeFullname,
            }).ToList();
            scheduleTable.ItemsSource = scheduleDetails;
        }

        private void DoChangeStatus(object sender, RoutedEventArgs e)
        {
            int id;
            Int32.TryParse(idText.Text, out id);
            MaintenanceController.DoChangeMaintainStatus(id);
            MaintenanceHomePage maintenanceHomePage = new MaintenanceHomePage();
            this.NavigationService.Navigate(maintenanceHomePage);
            MessageBox.Show("Maintain Status Changed !");
        }
    }
}
