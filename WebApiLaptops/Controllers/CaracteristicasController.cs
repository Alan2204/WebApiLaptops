using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiLaptops.Entidades;

namespace WebApiLaptops.Controllers
{

    [ApiController]
    [Route("api/caracteristicas")]
    public class CaracteristicasController
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
    }
}
