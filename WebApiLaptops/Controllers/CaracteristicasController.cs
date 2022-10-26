using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiLaptops.Entidades;

namespace WebApiLaptops.Controllers
{
<<<<<<< HEAD
    [ApiController]
    [Route("api/caracteristicas")]
    public class CaracteristicasController : ControllerBase
=======

    [ApiController]
    [Route("api/caracteristicas")]
    public class CaracteristicasController
>>>>>>> 0ce185813bd1120e2945be2041e297f00633c0c7
    {
        private readonly ApplicationDbContext dbContext;
        public CaracteristicasController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Caracteristicas>>> GetAll()
        {
            return await dbContext.Caracteristicas.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Caracteristicas>> GetById(int id)
        {
            return await dbContext.Caracteristicas.FirstOrDefaultAsync(x => x.Id == id);
        }
<<<<<<< HEAD

        [HttpPost]
        public async Task<ActionResult> Post(Caracteristicas caracteristicas)
        {
            var existeModelo = await dbContext.Laptops.AnyAsync(x => x.Id == caracteristicas.MarcaId);

            if (!existeModelo)
            {
                return BadRequest($"No existe la marca con el id: {caracteristicas.MarcaId}");
            }

            dbContext.Add(caracteristicas);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Caracteristicas caracteristicas, int id)
        {
            var exist = await dbContext.Caracteristicas.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound("El modelo especifico no existe");

            }
            if(caracteristicas.Id != id)
            {
                return BadRequest("El id del modelo coincide con lo establecido en la url");
            }

            dbContext.Update(caracteristicas);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Caracteristicas.AnyAsync(x => x.Id == id);
            if(!exist)
            {
                return NotFound("El recurso no fue encontrado.");
            }
            dbContext.Remove(new Caracteristicas { Id = id });
            await dbContext.SaveChangesAsync();
            return Ok();
        }

=======
>>>>>>> 0ce185813bd1120e2945be2041e297f00633c0c7
    }
}
