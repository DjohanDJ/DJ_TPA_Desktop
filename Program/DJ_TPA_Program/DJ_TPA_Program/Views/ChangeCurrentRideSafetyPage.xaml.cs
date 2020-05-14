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
    
    public partial class ChangeCurrentRideSafetyPage : Page
    {
        public ChangeCurrentRideSafetyPage()
        {
            InitializeComponent();
        }

        private void DoSubmitButton(object sender, RoutedEventArgs e)
        {
            RideCreationController.DoPrepareSafety(forceText.Text);
            RideCreationController.DoChangeRide();
            CreativeHomePage creativeHomePage = new CreativeHomePage();
            this.NavigationService.Navigate(creativeHomePage);
            MessageBox.Show("Ride Changed !");
        }

    }
}
