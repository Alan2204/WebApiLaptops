using System.ComponentModel.DataAnnotations;

namespace WebApiLaptops.DTOs
{
    public class CaracteristicasDTO
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Procesador { get; set; }
        public string Grafica { get; set; }
        public int Ram { get; set; }
        public string TipoMemoria { get; set; }
        public int Memoria { get; set; }
        public string SistemaOperativo { get; set; }
        public int Resolucion { get; set; }
        public int Precio { get; set; }
    }
}
