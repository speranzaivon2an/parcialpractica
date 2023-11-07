using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context:DbContext
    {
        public DbSet<Entidades.Biblioteca> bibliotecas { get; set; }
        public DbSet<Entidades.Libro> libros { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(Localdb)\ProjectModels;Initial Catalog=Seguridad;Integrated Security=true");

        }
    }
}