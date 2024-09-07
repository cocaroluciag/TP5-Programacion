using AppFakeStore2.Models;
using AppFakeStore2.Utils;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppFakeStore2.ViewModels;

public partial class ProductoDetalleViewModel : BaseViewModel
{
    [ObservableProperty]
    Producto producto;

    public ProductoDetalleViewModel()
    {
        Title = "DETALLE DEL PRODUCTO";
    }

    [RelayCommand]
    private async Task GoBack()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }
}
