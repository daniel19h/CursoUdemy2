using System.ComponentModel.DataAnnotations;
using WebApiAutores2Udemy.Validation;

namespace WebApiAutores2Udemy.DTOs
{
    public class AutorCreacionDTO
    {
        [Required(ErrorMessage = "El Campo {0} es requerido")]
        [StringLength(maximumLength: 100, ErrorMessage = "el campo {0} no debe tener mas de {1} caracteres")]
        [PrimeraLetraM]
        public string Nombre { get; set; }
    }
}
