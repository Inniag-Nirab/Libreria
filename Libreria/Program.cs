namespace Libreria
{
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public Libro(string isbn, string titulo, string autor, int numeroPaginas)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }

        public override string ToString()
        {
            return $"El libro con ISBN {ISBN} creado por {Autor} tiene {NumeroPaginas} páginas";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("978-3-16-148410-0", "Suma de Teológica", "St. Tomás de Aquino", 5000);
            Libro libro2 = new Libro("978-1-56619-909-4", "Así Habló Zaratustra", "Friedrich Niezstche", 200);

            Console.WriteLine(libro1.ToString());
            Console.WriteLine(libro2.ToString());

            if (libro1.NumeroPaginas > libro2.NumeroPaginas)
            {
                Console.WriteLine("El libro uno tiene más páginas.");
            }
            else if (libro1.NumeroPaginas < libro2.NumeroPaginas)
            {
                Console.WriteLine("El libro dos tiene más páginas.");
            }
            else
            {
                Console.WriteLine("Ambos libros tienen el mismo número de páginas.");
            }
        }
    }
}
