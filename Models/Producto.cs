// Libro.cs
public class Libro
{
    public int ID { get; set; }
    public string Titulo { get; set; }

    // Clave foránea
    public int AutorID { get; set; }

    // Propiedad de navegación
    public Autor Autor { get; set; }

    // Constructor
    public Libro()
    {
        Titulo = string.Empty; // Inicializa la propiedad Titulo
        Autor = new Autor();   // Puedes ajustar esto según tus necesidades
    }
}

// Autor.cs
public class Autor
{
    public int AutorID { get; set; }
    public string Nombre { get; set; }

    // Propiedad de navegación
    public List<Libro> Libros { get; set; }

    // Constructor
    public Autor()
    {
        Nombre = string.Empty;   // Inicializa la propiedad Nombre
        Libros = new List<Libro>(); // Inicializa la propiedad Libros
    }
}
