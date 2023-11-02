using ConstructionManagement.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConstructionManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public static List<Item> items = new List<Item>()
        {
            new Item { Id = 1, vehicle = new Vehicle{ Id = 1, NumberPlate = "MH12PK818", AvaibilityStatus = "Available"} },
            new Item { Id = 2, vehicle = new Vehicle{ Id = 2, NumberPlate = "MH12PK818", AvaibilityStatus = "Available"} }
        };
        public static List<Order> Orders = new List<Order>()
        {
            new Order() { Id = 1, User = "Jai", Items = items }
        };

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetOrders()
        {
            return Ok(Orders);
        }
    }
}
