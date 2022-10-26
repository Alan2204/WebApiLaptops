using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiLaptops.Entidades;

namespace WebApiLaptops.Controllers
{
    [ApiController]
    [Route("api/Laptops")]
    public class LaptopsController : ControllerBase
     {
        private readonly ApplicationDbContext dbContext;
        public LaptopsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Laptop>>> Get()
        {
            return await dbContext.Laptops.ToListAsync();
            
        }

        [HttpPost]
        public async Task<ActionResult> Post(Laptop laptop)
        {
            dbContext.Add(laptop);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
     }
   
}
