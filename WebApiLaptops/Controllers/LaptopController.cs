using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebApiLaptops.DTOs;
using WebApiLaptops.Entidades;


namespace WebApiLaptops.Controllers
{
    [ApiController]
    [Route("api/Laptops")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
    public class LaptopsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;
        
        public LaptopsController(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<GetLapDTO>>> Get()
        {
            var laptop = await dbContext.Laptops.ToListAsync();
            return mapper.Map<List<GetLapDTO>>(laptop);
        }

        [HttpPost]
       
        public async Task<ActionResult> Post([FromBody] LaptopDTO laptopDto)
        {
            var mismo = await dbContext.Laptops.AnyAsync(x => x.Marca == laptopDto.Marca);
            if (mismo)
            {
                return BadRequest($"Ya existe {laptopDto.Marca} en la base de datos. ");
            }

            var laptop = mapper.Map<Laptop>(laptopDto);

            dbContext.Add(laptop);
            await dbContext.SaveChangesAsync();

            var laptopDTO = mapper.Map<GetLapDTO>(laptop);
            
            return CreatedAtRoute("obtenerlap", new {id = laptop.Id}, laptopDTO);
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
