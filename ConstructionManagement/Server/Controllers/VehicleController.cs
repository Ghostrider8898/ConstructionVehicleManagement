using ConstructionManagement.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConstructionManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        public static List<VehicleCategory> VehicleCategories = new List<VehicleCategory>() { 
            new VehicleCategory {
                Id = 1,
                Category = "Extraction",
                RatePerHour = 1000,
            },
            new VehicleCategory {
                Id = 2,
                Category = "Heavy",
                RatePerHour = 2500,
            }
        };

        public static List<Vehicle> vehicles = new List<Vehicle>() { 
            new Vehicle{ 
                Id = 1,
                NumberPlate = "MH12PK9000",
                AvaibilityStatus = "Available",
                vehicleCategory = VehicleCategories[0],
            },
            new Vehicle{
                Id = 2,
                NumberPlate = "MH12KU1991",
                AvaibilityStatus = "Available",
                vehicleCategory = VehicleCategories[1],
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Vehicle>>> GetVehicles()
        {
            return Ok(vehicles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> GetVehiclebyId(int Id)
        {
            var vehicle = vehicles.FirstOrDefault(x => x.Id == Id);
            if (vehicle == null)
                return NotFound("No Vehicle found.");

            return Ok(vehicle);
        }
    }
}
