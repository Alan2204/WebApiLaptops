using System.ComponentModel.DataAnnotations;

namespace WebApiLaptops.DTOs
{
    public class EditarAdminDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
