using WebApiAutores2Udemy.Validation;

namespace WebApiAutores2Udemy.DTOs
{
    public class LibroCreacionDTO
    {
        

        [PrimeraLetraM]
        public string Titulo { get; set; }
        public DateTime FechaPublicion  { get; set; }
        public List<int> AutoresIds { get; set; }
    }
}
