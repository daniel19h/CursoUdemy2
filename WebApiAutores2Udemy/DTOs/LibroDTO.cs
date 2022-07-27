namespace WebApiAutores2Udemy.DTOs
{
    public class LibroDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public DateTime FechaPubliacion { get; set; }   
        

        // listado de comentarios dto
        //public List<ComentarioDTO> Comentarios{ get; set; }
    }
}
