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
    
    public partial class FiringReasonPage : Page
    {
        public FiringReasonPage()
        {
            InitializeComponent();
        }

        private void DoAddFiringReason(object sender, RoutedEventArgs e)
        {
            EmployeeController.DoAddFiringReason(reasonText.Text);
            HRDHomePage hrdHomePage = new HRDHomePage();
            this.NavigationService.Navigate(hrdHomePage);
            MessageBox.Show("Reason Added !");
        }

    }
}
