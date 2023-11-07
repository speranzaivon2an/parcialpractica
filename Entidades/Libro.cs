namespace Entidades
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Autor { get; set; }
        public string Nombre { get; set; }
        public TimeSpan FechaLanzamiento { get; set; }
        public string Editorial { get; set; }

        public Genero Generoo { get; set; }

        public void Add(Libro libro)
        {
            throw new NotImplementedException();
        }

        public class Genero
        {
        }
    }
}