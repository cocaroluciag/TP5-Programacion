using AppFakeStore2.Models;
using AppFakeStore2.ViewModels;

namespace AppFakeStore2.Views;

public partial class ProductoDetallePage : ContentPage
{
    public ProductoDetallePage(Producto param)
    {
        InitializeComponent();

        ProductoDetalleViewModel vm = new ProductoDetalleViewModel();
        this.BindingContext = vm;
        vm.Producto = param;
    }
}