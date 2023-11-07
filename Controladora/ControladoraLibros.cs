using Entidades;
using Modelo;
using System.Text.RegularExpressions;


namespace Controladora
{
    public class ControladoraLibros
    {

        public Modelo.Context context;
        public ControladoraLibros()
        {
            context = new Modelo.Context();

        }
        public string Agregar(Libro libro)
        {
            var libroencontrado = context.libros.FirstOrDefault(x => x.Nombre == libro.Nombre );
            if (libroencontrado == null)
            {
                context.libros.Add(libro);
                libro.ToString();
                return "Turno agregado";
            }
            else return "Turno no habilitado";
        }

        public string Eliminar(Libro libro)
        {
            var libroencontrado = context.libros.FirstOrDefault(x => x.Nombre == libro.Nombre);
            if (libroencontrado != null)
            {
                context.Remove(libroencontrado);
                context.SaveChanges();
                return "Libro correctamente eliminado";
            }
            else return "No se ha encontrado el libro a eliminar";
        }
        public Libro Buscar(Libro libro)
        {
            var libroencontrado = context.libros.FirstOrDefault(x => x.Nombre == libro.Nombre);
            if (libroencontrado == null)
            {
                return libroencontrado;
            }
            else return null;
        }

        public string Modificar(Libro libro)
        {
            context.libros.Update(libro);
            context.SaveChanges();
            return "Libro modificado";
        }

    }
}