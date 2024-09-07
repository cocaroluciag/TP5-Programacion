using AppFakeStore2.Models;
using AppFakeStore2.Services;
using AppFakeStore2.ViewModels;

namespace AppFakeStore2.Views;

public partial class UserDetallePage : ContentPage
{
    private readonly UserDetalleViewModel _viewModel;

    public UserDetallePage(int userId)
    {
        InitializeComponent();
        var userService = new UserService();
        _viewModel = new UserDetalleViewModel(userService);
        BindingContext = _viewModel;
        _viewModel.LoadUserDetailsAsync(userId);
    }
}