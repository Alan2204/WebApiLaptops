using AutoMapper;
using System.Data.Common;
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
            CreateMap<LaptopDTO, Laptop>();
            CreateMap<Laptop, GetLapDTO>();
            CreateMap<Caracteristicas, CarcteristicasDTOLap>()
                .ForMember(lap => lap.Modelo, opciones =>opciones.MapFrom(MapLaptopDTOCaracteristica));
            CreateMap<Caracteristicas, CaracteristicasPostDTO>();
            CreateMap<Laptop, LaptopDTOCaracteristicas>();
                
            
        }

        private List<LaptopDTO> MapLaptopDTOCaracteristica(Caracteristicas caracteristicas, CaracteristicasDTO caracteristicasDto)
        {
            var result = new List<LaptopDTO>();

            if(caracteristicas.LapCaracteristica == null) { return result; }

            foreach(var caracteristicaLap in caracteristicas.LapCaracteristica)
            {
                result.Add(new LaptopDTO()
                {
                    Marca = caracteristicaLap.Caracteristicas.Modelo

                });
            }

            return result;
        }

 


    }
}
