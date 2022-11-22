using System.ComponentModel.DataAnnotations;

namespace WebApiLaptops.DTOs
{
    public class GetLapDTO
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public int Provedor { get; set; }
        public int Stock { get; set; }
    }
}
