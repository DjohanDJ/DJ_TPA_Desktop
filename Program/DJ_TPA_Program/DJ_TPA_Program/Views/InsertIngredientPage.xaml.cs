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
    /// Interaction logic for InsertIngredientPage.xaml
    /// </summary>
    public partial class InsertIngredientPage : Page
    {
        public InsertIngredientPage()
        {
            InitializeComponent();
        }

        private void DoInsertButton(object sender, RoutedEventArgs e)
        {
            int quantity;
            Int32.TryParse(quantityBox.Text, out quantity);

            IngredientController.DoInsertIngredient(attNameText.Text, quantity);
            KitchenHomePage kitHome = new KitchenHomePage();
            this.NavigationService.Navigate(kitHome);
            MessageBox.Show("Ingredient Inserted !");
        }

    }
}
