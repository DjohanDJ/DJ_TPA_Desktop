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
    
    public partial class CreativeHomePage : Page
    {
        public CreativeHomePage()
        {
            InitializeComponent();
            DoInitializeUser();
        }

        private void DoInitializeUser()
        {
            userLabelText.Text = "Welcome, " + ActiveUserController.GetActiveEmployee().EmployeeFullname;
        }

        private void DoPlanNewRide(object sender, RoutedEventArgs e)
        {
            PlanNewRidePage planNewRidePage = new PlanNewRidePage();
            this.NavigationService.Navigate(planNewRidePage);
        }

        private void DoChangeCurrentRide(object sender, RoutedEventArgs e)
        {
            ChangeCurrentRidePage changeCurrentRidePage = new ChangeCurrentRidePage();
            this.NavigationService.Navigate(changeCurrentRidePage);
        }

        private void DoDeleteCurrentRide(object sender, RoutedEventArgs e)
        {
            DeleteCurrentRidePage deleteCurrentRidePage = new DeleteCurrentRidePage();
            this.NavigationService.Navigate(deleteCurrentRidePage);
        }

        private void DoViewAllRide(object sender, RoutedEventArgs e)
        {
            ViewAllRidePage viewAllRidePage = new ViewAllRidePage();
            this.NavigationService.Navigate(viewAllRidePage);
        }

        private void DoRequestIdeaToManager(object sender, RoutedEventArgs e)
        {
            RequestIdeaToManagerPage requestIdeaToManager = new RequestIdeaToManagerPage();
            this.NavigationService.Navigate(requestIdeaToManager);
        }

        private void DoChangeProgressStatus(object sender, RoutedEventArgs e)
        {
            ChangeProgressStatusPage changeProgressStatusPage = new ChangeProgressStatusPage();
            this.NavigationService.Navigate(changeProgressStatusPage);
        }

        private void DoLeavingPermission(object sender, RoutedEventArgs e)
        {
            RequestLeavingPermissionPage reqLeaving = new RequestLeavingPermissionPage();
            this.NavigationService.Navigate(reqLeaving);
        }

        private void DoResignLetter(object sender, RoutedEventArgs e)
        {
            CreateResignLetterPage resignPage = new CreateResignLetterPage();
            this.NavigationService.Navigate(resignPage);
        }

        private void DoRequestItem(object sender, RoutedEventArgs e)
        {
            RequestItemPage requestItemPage = new RequestItemPage();
            this.NavigationService.Navigate(requestItemPage);
        }

        private void DoViewManagerResponse(object sender, RoutedEventArgs e)
        {
            ViewManagerResponsePage viewManagerResponsePage = new ViewManagerResponsePage();
            this.NavigationService.Navigate(viewManagerResponsePage);
        }

        private void DoLogout(object sender, RoutedEventArgs e)
        {
            ActiveUserController.SetActiveEmployee(null);
            LoginPage loginPage = new LoginPage();
            this.NavigationService.Navigate(loginPage);
        }

    }
}
