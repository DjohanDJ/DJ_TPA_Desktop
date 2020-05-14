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
    /// <summary>
    /// Interaction logic for CreateResignLetterPage.xaml
    /// </summary>
    public partial class CreateResignLetterPage : Page
    {

        private int userId = ActiveUserController.GetActiveEmployee().Id;

        public CreateResignLetterPage()
        {
            InitializeComponent();
        }

        private void DoLoadTableData()
        {
            var leavingDetails = (from x in ConnectionController.GetInstance().ResignRequests
            select new
            {
                Id = x.EmployeeId,
                ResignName = "You",
                ResignLetter = x.ResignLetter,
                ResignDate = x.ResignDate,
                ResignResponse = x.ResignResponse
            }).Where(x => x.Id.Equals(userId)).ToList();
            leavingTable.ItemsSource = leavingDetails;
        }

        private void DoLeavingRequest(object sender, RoutedEventArgs e)
        {
            EmployeeController.DoRequestResign(resignDate.Text, resignText.Text);
            MessageBox.Show("Resign Permission Sent !");
            DoLoadTableData();
        }

    }
}
