using Microsoft.AspNetCore.Mvc;
using WebApiLaptops.Entidades;

namespace WebApiLaptops.Controllers
{
    [ApiController]
    [Route("api/Laptops")]
    public class LaptopsController : ControllerBase
     {
        [HttpGet]
        public ActionResult<List<Laptop>> Get()
        {
            return new List<Laptop>
            {
                new Laptop() { Id = 1, Marca = "Bravo17" },
                new Laptop() { Id = 2, Marca = "Bravo15" }
            };

        }
     }
   
}
