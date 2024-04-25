using Warehouse.Repositories.Interfaces;
using Warehouse.RequestDTO;

namespace Warehouse.Services;

public class ProductWarehouseService(
    IProductRepository productRepository) : IProductWarehouseService
{
    public async Task<bool> Add(AddProductWarehouseDTO productWarehouse)
    {
        var productId = await productRepository.GetById(productWarehouse.IdProduct);
    }
}