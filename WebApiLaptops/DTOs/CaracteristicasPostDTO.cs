using System.ComponentModel.DataAnnotations;
using WebApiLaptops.Entidades;

namespace WebApiLaptops.DTOs
{
    public class CaracteristicasPostDTO
    {
        public int MarcaId { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Procesador { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Grafica { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int Ram { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string TipoMemoria { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int Memoria { get; set; }
        public string SistemaOperativo { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int Resolucion { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Range(2000, 100000, ErrorMessage = "Precio no valido. ")]
        public int Precio { get; set; }
       
    }
}
