using WebApiAutores2Udemy.Validation;

namespace WebApiAutores2Udemy.DTOs
{
    public class LibroPatchDTO
    {
        [PrimeraLetraM]
        public string Titulo { get; set; }
        public DateTime FechaPublicion { get; set; }
    }
}
