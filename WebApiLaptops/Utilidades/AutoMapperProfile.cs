using AutoMapper;
using WebApiLaptops.DTOs;
using WebApiLaptops.Entidades;

namespace WebApiLaptops.Utilidades
{
    //Aqui se papean las entgidades para que hagan conexion con los DDTO
    //Una entidad es una referencia a la base de datos
    //Los DTO sirven para que la entidad no quede expuesta a la gente.
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Caracteristicas, CaracteristicasPostDTO>();
            CreateMap<Laptop, GetLapDTO>();
        }

        /*private List<LaptopDTO> MapCaracteristicasDTOLap(Caracteristicas caracteristicas, CaracteristicasDTO caracteristicasDto)
        {
            var result = new List<LaptopDTO>();

            if(caracteristicas.Marca == null) { return result; }

            foreach(var caracteristicaLap in caracteristicas.Marca)
            {
                result.Add(new LaptopDTO()
                {

                });
            }

            return result;
        }*/
    }
}
