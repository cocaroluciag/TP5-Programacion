using AppFakeStore2.Services;
using AppFakeStore2.ViewModels;

namespace AppFakeStore2.Views;

public partial class UserListaPage : ContentPage
{
    public UserListaPage()
    {
        UserService service = new UserService();
        UserListaViewModel vm = new UserListaViewModel(service);
        InitializeComponent();
        this.BindingContext = vm;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        var vm = BindingContext as UserListaViewModel;

        if (vm != null)
        {
            await vm.GetUsersCommand.ExecuteAsync(null);
        }
    }
}