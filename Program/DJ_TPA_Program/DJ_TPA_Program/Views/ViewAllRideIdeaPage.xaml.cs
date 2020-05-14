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

    public partial class ViewAllRideIdeaPage : Page
    {
        public ViewAllRideIdeaPage()
        {
            InitializeComponent();
            DoLoadTableData();
        }

        private void DoLoadTableData()
        {
            var ideaDetails = (from x in ConnectionController.GetInstance().HeaderResponses
            select new
            {
                Id = x.Id,
                RideName = x.Ride.RideName,
                RideSafety = x.Ride.RideSafety.RideSafetyName,
                RideType = x.Ride.RideType.RideTypeName,
                IdeaFrom = x.Employee.EmployeeFullname,
                Status = x.ResponseStatus
            }).Where(x => x.Status.Equals("Waiting")).ToList();
            rideIdeaTable.ItemsSource = ideaDetails;
        }

        private void DoGiveResponse(object sender, RoutedEventArgs e)
        {
            int id;
            Int32.TryParse(idText.Text, out id);
            ManagerController.DoChangeStatus(id, responseText.Text);
            ManagerHomePage managerHomePage = new ManagerHomePage();
            this.NavigationService.Navigate(managerHomePage);
            MessageBox.Show("Response Sent !");
        }

    }
}
