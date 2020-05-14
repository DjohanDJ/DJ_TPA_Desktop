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

    public partial class ViewAllEmployeeLeavingRequestPage : Page
    {
        public ViewAllEmployeeLeavingRequestPage()
        {
            InitializeComponent();
            DoLoadTableData();
        }

        private void DoLoadTableData()
        {
            var leavingDetails = (from x in ConnectionController.GetInstance().LeavingPermissions
            select new
            {
                Id = x.Id,
                EmlpoyeeId = x.EmployeeId,
                EmployeeName = x.Employee.EmployeeFullname,
                EmployeeReason = x.Reason,
                LeavingStartDate = x.StartDate,
                LeavingEndDate = x.EndDate,
                LeavingStatus = x.ResponseStatus
            }).Where(x => x.LeavingStatus.Equals("Waiting")).ToList();
            leavingTable.ItemsSource = leavingDetails;
        }

        private void DoGiveResponse(object sender, RoutedEventArgs e)
        {
            int id;
            Int32.TryParse(idText.Text, out id);
            EmployeeController.DoChangePermissionStatus(id, responseText.Text);
            HRDHomePage hrdHomePage = new HRDHomePage();
            this.NavigationService.Navigate(hrdHomePage);
            MessageBox.Show("Response Sent !");
        }

    }
}
