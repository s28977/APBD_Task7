using Microsoft.AspNetCore.Mvc;
using Warehouse.RequestDTO;
using Warehouse.Services;

namespace Warehouse.Controllers;

[ApiController]
public class WarehouseController(IProductWarehouseService productWarehouseService) : ControllerBase
{
    [HttpPost("warehouse/add")]
    public IActionResult Create([FromBody] AddProductWarehouseDTO productWarehouse)
    {
        productWarehouseService.Add(productWarehouse);
    }
}