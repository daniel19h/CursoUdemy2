using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApiAutores2Udemy.Entities;

namespace WebApiAutores2Udemy.Contexts
{
    public class ApplicationDbContext: IdentityDbContext 
    {
        public ApplicationDbContext(DbContextOptions opt) : base(opt)
        {
                
        }

        //api fuente, 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //entidad autor libro has key tiene llave new autor id
            modelBuilder.Entity<AutorLibro>()
                .HasKey(al => new { al.AutorId, al.LibroId});
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<AutorLibro> AutoresLibros { get; set; }
    }
}
