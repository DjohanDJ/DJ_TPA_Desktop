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

    public partial class RequestLeavingPermissionPage : Page
    {
        private int userId = ActiveUserController.GetActiveEmployee().Id;

        public RequestLeavingPermissionPage()
        {
            InitializeComponent();
            DoLoadTableData();
        }

        private void DoLoadTableData()
        {
            var leavingDetails = (from x in ConnectionController.GetInstance().LeavingPermissions
            select new
            {
                Id = x.EmployeeId,
                LeavingName = "You",
                LeavingReason = x.Reason,
                LeavingStartDate = x.StartDate,
                LeavingEndDate = x.EndDate,
                LeavingStatus = x.ResponseStatus
            }).Where(x => x.Id.Equals(userId)).ToList();
            leavingTable.ItemsSource = leavingDetails;
        }

        private void DoLeavingRequest(object sender, RoutedEventArgs e)
        {
            EmployeeController.DoRequestLeaving(startTime.Text, endTime.Text, reasonText.Text);
            MessageBox.Show("Leaving Permission Sent !");
            DoLoadTableData();
        }

    }
}
