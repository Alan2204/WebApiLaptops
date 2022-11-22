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
        }
    }
}
