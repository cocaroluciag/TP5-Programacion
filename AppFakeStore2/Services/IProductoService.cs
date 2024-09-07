using AppFakeStore2.Models;

namespace AppFakeStore2.Services;

public interface IProductoService
{
    Task<IEnumerable<Producto>> GetProductsAsync();
}