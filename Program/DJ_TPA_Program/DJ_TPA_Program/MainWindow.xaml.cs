using DJ_TPA_Program.Views;
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

namespace DJ_TPA_Program
{
    public partial class MainWindow : Window
    {
        LoginPage loginPage;

        public MainWindow()
        {
            InitializeComponent();
            InitializeFrame();
        }

        public void InitializeFrame()
        {
            loginPage = new LoginPage();
            myFrame.NavigationService.Navigate(loginPage);
        }

    }
}
