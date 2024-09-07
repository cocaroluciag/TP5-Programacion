using AppFakeStore2.Services;
using AppFakeStore2.ViewModels;
using AppFakeStore2.Utils;
using AppFakeStore2.Views;

namespace AppFakeStore2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new AppShell();
            MainPage = new NavigationPage(new MainPage());
            ShowLoginPage();
        }

        private async void ShowLoginPage()
        {
            await MainPage.Navigation.PushModalAsync(new NavigationPage(new LoginPage()));
        }
    }
}