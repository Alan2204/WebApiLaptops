using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiLaptops.DTOs;
using WebApiLaptops.Entidades;

namespace WebApiLaptops.Controllers
{
    [ApiController]
    [Route("api/caracteristicas")]
    public class CaracteristicasController : ControllerBase
    {    
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public CaracteristicasController(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Caracteristicas>>> GetAll()
        {           
            return await dbContext.Caracteristicas.ToListAsync();
            //throw new NotImplementedException();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Caracteristicas>> GetById(int id)
        { 
            return await dbContext.Caracteristicas.FirstOrDefaultAsync(x => x.Id == id);
        }


        [HttpPost]
        public async Task<ActionResult> Post( CaracteristicasPostDTO caracteristicasDTO)
        {
            var existeModelo = await dbContext.Laptops.AnyAsync(x => x.Id == caracteristicasDTO.MarcaId);
            var mismo = await dbContext.Caracteristicas.AnyAsync(x => x.Modelo == caracteristicasDTO.Modelo);

            if (!existeModelo)
            {
                
                return BadRequest($"No existe la marca con el id: {caracteristicasDTO.MarcaId}");
            }

            if (mismo)
            {
                
                return BadRequest("Ya existe un modelo con el mismo nombre en la base de datos. ");

            }

            var caracteristicas = mapper.Map<Caracteristicas>(caracteristicasDTO);
 
            dbContext.Add(caracteristicas);
            await dbContext.SaveChangesAsync();

            var caraDTO = mapper.Map<CaracteristicasPostDTO>(caracteristicas);
            return CreatedAtRoute("Obtener info", new {id = caracteristicasDTO.MarcaId}, caraDTO);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Caracteristicas caracteristicas, int id)
        {
            
            var exist = await dbContext.Caracteristicas.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                
                return NotFound("El modelo especifico no existe");

            }
            if (caracteristicas.Id != id)
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
            if (!exist)
            {
                
                return NotFound("El recurso no fue encontrado.");
            }
            dbContext.Remove(new Caracteristicas { Id = id });
            await dbContext.SaveChangesAsync();
            return Ok();
        }


        
    }
}