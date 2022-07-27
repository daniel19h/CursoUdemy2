using Microsoft.AspNetCore.Identity;

namespace WebApiAutores2Udemy.Entities
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Contenido { get; set; }

        // va a contener el comentario del libro
        public int LibroId { get; set; }

        //propiedad de navegacion para pasar de una propiedad a otra
        public Libro Libro { get; set; }


        // realizaremos relacion entre comentarios y usuarios.
        // que solos usuarios puedan ver los comentarios
        public string UsuarioId { get; set; }
        public IdentityUser  Usuario { get; set; }


    }
}
