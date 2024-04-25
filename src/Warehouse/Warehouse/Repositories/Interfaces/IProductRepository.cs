using Warehouse.Entities;

namespace Warehouse.Repositories.Interfaces;

public interface IProductRepository
{
    Task<Product?> GetById(int idProduct);
}