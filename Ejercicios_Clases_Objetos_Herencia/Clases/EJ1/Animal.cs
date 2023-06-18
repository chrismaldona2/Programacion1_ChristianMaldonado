namespace Clases.EJ1
{
    public class Animal
    {
        public string nombre { get; set; }

        public Animal(string nombre)
        {
            this.nombre = nombre;
        }
        public virtual void HacerSonido()
        {
            Console.WriteLine($"El {nombre} hace un sonido.");
        }
    }
}