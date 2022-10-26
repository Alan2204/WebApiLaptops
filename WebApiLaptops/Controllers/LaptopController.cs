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

        [HttpPut ("{id:int}")]
        public async Task<ActionResult> Put(Laptop laptop, int id)
        {
            if(laptop.Id != id)
            {
                return BadRequest("El id de la laptop no coincide con el establecido en la url");

            }

            dbContext.Update(laptop);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete ("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Laptops.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound();
            }
            dbContext.Remove(new Laptop()
            {
                Id = id
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }
     }
   
}
