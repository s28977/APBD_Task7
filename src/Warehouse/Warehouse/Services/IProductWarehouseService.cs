using Warehouse.RequestDTO;

namespace Warehouse.Services;

public interface IProductWarehouseService
{ 
    Task<bool> Add(AddProductWarehouseDTO productWarehouse);
}