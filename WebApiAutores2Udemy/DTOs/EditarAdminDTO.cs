using System.ComponentModel.DataAnnotations;

namespace WebApiAutores2Udemy.DTOs
{
    public class EditarAdminDTO
    {
        [Required]
        [EmailAddress]
        public string Email {  get; set; }
    }
}
