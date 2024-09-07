using AppFakeStore2.Services;
using AppFakeStore2.ViewModels;

namespace AppFakeStore2.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        BindingContext = new LoginViewModel();
    }
}