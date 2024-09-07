using AppFakeStore2.Services;
using AppFakeStore2.ViewModels;

namespace AppFakeStore2.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        MainViewModel viewModel = new MainViewModel();
        this.BindingContext = viewModel;
    }
}