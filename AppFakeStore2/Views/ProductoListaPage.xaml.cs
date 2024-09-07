using AppFakeStore2.Services;
using AppFakeStore2.ViewModels;

namespace AppFakeStore2.Views;

public partial class ProductoListaPage : ContentPage
{
    public ProductoListaPage()
    {
        ProductoService service = new ProductoService();
        ProductoListaViewModel vm = new ProductoListaViewModel(service);
        InitializeComponent();
        this.BindingContext = vm;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        var vm = BindingContext as ProductoListaViewModel;

        if (vm != null)
        {
            await vm.GetProductosCommand.ExecuteAsync(null);
        }
    }
}