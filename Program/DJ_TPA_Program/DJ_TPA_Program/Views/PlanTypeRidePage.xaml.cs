using DJ_TPA_Program.Controllers;
using DJ_TPA_Program.Models;
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
    

    public partial class PlanTypeRidePage : Page
    {

        private List<RideType> rideTypes { get; set; }

        public PlanTypeRidePage()
        {
            InitializeComponent();
            DoFeedRideTypeComboBox();
        }

        private void DoFeedRideTypeComboBox()
        {
            var rideType = ConnectionController.GetInstance().RideTypes.ToList();
            rideTypes = rideType;
            DataContext = rideTypes;
        }

        private void DoNextButton(object sender, RoutedEventArgs e)
        {
            PlanSafetyPage planSafetyPage = new PlanSafetyPage();
            this.NavigationService.Navigate(planSafetyPage);
            RideCreationController.DoPrepareType(rideTypeBox.Text);
        }

    }
}
