using System.ComponentModel.DataAnnotations;

namespace WebApiLaptops.Entidades
{
    public class Laptop
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Range(1,5)]
        public int Provedor { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Range (0,100, ErrorMessage ="Solo puede haber stock de 0 a 100. ")]
        public int Stock { get; set; }
    }
}
