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
    /// Interaction logic for PlanNewAttractionPage.xaml
    /// </summary>
    public partial class PlanNewAttractionPage : Page
    {
        public PlanNewAttractionPage()
        {
            InitializeComponent();
        }

        private void DoSubmitButton(object sender, RoutedEventArgs e)
        {
            int durability, quantity;
            Int32.TryParse(durabilityBox.Text, out durability);
            Int32.TryParse(quantityBox.Text, out quantity);

            AttractionCreationController.DoInsertAttraction(attNameText.Text, durability, quantity, startDate.Text);
            CreativeHomePage creativeHomePage = new CreativeHomePage();
            this.NavigationService.Navigate(creativeHomePage);
            MessageBox.Show("Attraction Planned !");
        }
    }
}
