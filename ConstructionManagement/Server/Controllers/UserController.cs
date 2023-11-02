using ConstructionManagement.Client.Pages;
using ConstructionManagement.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConstructionManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public List<User> users = new List<User>()
        {
            new User{Id = 1 , FirstName = "jai", LastName = "bihani", Email = "jaibihani2013@gamil.com", Contact = "7057548898", Password = "jai", ConfirmPassword = "jai", ConstructionCompanyName = "Jai", DeliveryAddress = "Pune" }
        };

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUser()
        {
            return Ok(users);
        }
    }
}
