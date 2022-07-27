using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiAutores2Udemy.Validation;

namespace WebApiAutores2Udemy.Entities
{
    public class Autor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Campo {0} es requerido")]
        [StringLength(maximumLength:100, ErrorMessage = "el campo {0} no debe tener mas de {1} caracteres")]
        [PrimeraLetraM]
        public string Nombre { get; set; }

        public List<AutorLibro> AutoresLibros { get; set; }


    }


}
 