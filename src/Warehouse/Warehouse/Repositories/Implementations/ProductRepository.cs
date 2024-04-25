using Warehouse.Entities;
using Warehouse.Repositories.Interfaces;

namespace Warehouse.Repositories.Implementations;

public class ProductRepository(string connectionString) : IProductRepository
{
    public async Task<Product?> GetById(int idProduct)
    {
        Product? product = null;
        
        const string selectSchools = "SELECT Top 1 * FROM Country WHERE Id = @Id";
        using var con = new SqlConnection(connectionString);
        using var com = new SqlCommand(selectSchools, con);

        com.Parameters.AddWithValue("@Id", id);

        await con.OpenAsync();

        SqlDataReader reader = await com.ExecuteReaderAsync();
        if (reader.HasRows) 
        {
            while(reader.Read())
            {
                product = new Product {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                };
            }
        }

        return product;
    }
}