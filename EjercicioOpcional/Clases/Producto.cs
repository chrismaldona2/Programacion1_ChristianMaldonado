namespace Clases
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public string descripcion { get; set; }

        public static List<Producto> listaProductos()
        {
            List<Producto> productos = new List<Producto>();
            Libro libro1 = new Libro
            {
                idProducto = 1,
                nombre = "Don Quijote de la Mancha",
                precio = 2502.2m,
                descripcion = "Libro",
                autor = "Miguel de Cervantez",
                genero = "Novela",
                nroPaginas = 462
            };

            Pelicula pelicula1 = new Pelicula
            {
                idProducto = 2,
                nombre = "Requiem for a Dream",
                precio = 3012.3m,
                descripcion = "Pelicula",
                director = "Darren Aronofsky",
                duracion = "1h 42m",
                genero = "Drama",
                idioma = "Español"
            };

            Pelicula pelicula2 = new Pelicula
            {
                idProducto = 3,
                nombre = "Hereditary",
                precio = 2795.55m,
                descripcion = "Pelicula",
                director = "Ari Aster",
                duracion = "2h 6m",
                genero = "Horror",
                idioma = "Ingles subtitulado"
            };

            Disco disco1 = new Disco
            {
                idProducto = 4,
                nombre = "Thriller",
                precio = 2795.55m,
                descripcion = "Disco de Música",
                artista = "Michael Jackson",
                genero = "Pop",
                nroCanciones = 9,
            };

            productos.Add(libro1);
            productos.Add(pelicula1);
            productos.Add(pelicula2);
            productos.Add(disco1);

            return productos;
        }

        public static void verProductos()
        {
            Console.WriteLine("\n\n================== LISTA DE PRODUCTOS ==================\n");
            foreach (var producto in Producto.listaProductos())
            {
                if (producto is Pelicula)
                {
                    Console.WriteLine($"\n" +
                        $"    IdProducto: {producto.idProducto}\n" +
                        $"        Nombre: {producto.nombre}\n" +
                        $"        Precio: {producto.precio:c}\n" +
                        $"        Descripcion: {producto.descripcion}\n" +
                        $"        Director: {((Pelicula)producto).director}\n" +
                        $"        Duracion: {((Pelicula)producto).duracion}\n" +
                        $"        Genero: {((Pelicula)producto).genero}\n" +
                        $"        Idioma: {((Pelicula)producto).idioma}");
                }
                else if (producto is Libro)
                {
                    Console.WriteLine($"\n" +
                        $"    IdProducto: {producto.idProducto}\n" +
                        $"        Nombre: {producto.nombre}\n" +
                        $"        Precio: {producto.precio:c}\n" +
                        $"        Descripcion: {producto.descripcion}\n" +
                        $"        Autor: {((Libro)producto).autor}\n" +
                        $"        Genero: {((Libro)producto).genero}\n" +
                        $"        Número de páginas: {((Libro)producto).nroPaginas}");
                }
                else if (producto is Disco)
                {
                    Console.WriteLine($"\n" +
                        $"    IdProducto: {producto.idProducto}\n" +
                        $"        Nombre: {producto.nombre}\n" +
                        $"        Precio: {producto.precio:c}\n" +
                        $"        Descripcion: {producto.descripcion}\n" +
                        $"        Artista: {((Disco)producto).artista}\n" +
                        $"        Genero: {((Disco)producto).genero}\n" +
                        $"        Número de canciones: {((Disco)producto).nroCanciones}");
                }
                else
                {
                    Console.WriteLine($"\n" +
                        $"    IdProducto: {producto.idProducto}\n" +
                        $"        Nombre: {producto.nombre}\n" +
                        $"        Precio: {producto.precio:c}\n" +
                        $"        Descripcion: {producto.descripcion}\n");
                }
            }
            Console.WriteLine("\n========================================================\n\n");
        }
    }
}