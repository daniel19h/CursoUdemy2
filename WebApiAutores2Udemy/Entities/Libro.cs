using System.ComponentModel.DataAnnotations;
using WebApiAutores2Udemy.Validation;

namespace WebApiAutores2Udemy.Entities
{
    public class Libro
    {
        public int Id { get; set; }
        [Required]
        [PrimeraLetraM]
        public string Titulo { get; set; }
        public DateTime? FechaPublicacion { get; set; }

        //traer con un solo comando un comentario de un libro
        public List<Comentario> Comentarios { get; set; }
        public List<AutorLibro> AutoresLibros { get; set; }

    }
}
