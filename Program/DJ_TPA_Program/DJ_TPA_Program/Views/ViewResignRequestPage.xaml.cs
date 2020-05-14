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

    public partial class ViewResignRequestPage : Page
    {
        public ViewResignRequestPage()
        {
            InitializeComponent();
            DoLoadTableData();
        }

        private void DoLoadTableData()
        {
            var ideaDetails = (from x in ConnectionController.GetInstance().ResignRequests
            select new
            {
                Id = x.Id,
                EmployeeName = x.Employee.EmployeeFullname,
                ResignDate = x.ResignDate,
                ResignLetter = x.ResignLetter,
                Status = x.ResignResponse
            }).Where(x => x.Status.Equals("Waiting")).ToList();
            resignRequestTable.ItemsSource = ideaDetails;
        }

        private void DoGiveResponse(object sender, RoutedEventArgs e)
        {
            int id;
            Int32.TryParse(idText.Text, out id);
            ManagerController.DoChangeResignStatus(id, responseText.Text);
            ManagerHomePage managerHomePage = new ManagerHomePage();
            this.NavigationService.Navigate(managerHomePage);
            MessageBox.Show("Response Sent !");
        }

    }
}
