namespace Clases.Ej1
{
    public class Animal
    {
        private string nombre;
        public Animal(string nombre) 
        {
            this.nombre = nombre;
        }
        public virtual string hacerSonido()
        {
            return $"El animal '{nombre}' hace un sonido.";
        }
    }
}