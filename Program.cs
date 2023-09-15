using EjerciciosPracticos.Class;

namespace EjerciciosPracticos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EJERCICIO DE PONER NOMBRE Y LA EDAD DE UNA PERSONA
            /*
            Persona persona1= new Persona();
            Console.WriteLine("Escribe el nombre");
            persona1.Nombre = Console.ReadLine();
            Console.WriteLine("Escribe la edad");
            persona1.Edad= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tu nombre es " + persona1.Nombre);
            Console.WriteLine("Tu edad es" + persona1.Edad);
            */


            Vehiculo vehiculo1 = new Vehiculo();
            Console.WriteLine("Tu marca del auto es "+ vehiculo1.Marca);

            Auto auto1 = new Auto();
            Console.WriteLine("El auto es " +auto1.Marca);
            Console.WriteLine("El modelo del auto es " + auto1.Modelo);

        }
    }
}