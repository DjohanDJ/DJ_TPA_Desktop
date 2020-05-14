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

    public partial class RegisterCustomerPage : Page
    {
        public RegisterCustomerPage()
        {
            InitializeComponent();
        }

        private void DoRegisterButton(object sender, RoutedEventArgs e)
        {
            String[] customerData = new String[10];

            customerData[0] = fullnameText.Text;
            customerData[1] = emailText.Text;
            customerData[2] = phoneNumberText.Text;
            customerData[3] = addressText.Text;
            customerData[4] = genderBox.Text;
            customerData[5] = usernameText.Text;
            customerData[6] = passwordText.Text;

            CustomerController.InsertCustomer(customerData);
        }
    }
}
