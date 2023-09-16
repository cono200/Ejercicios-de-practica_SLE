using EjerciciosPracticos.Class;
using System.Reflection.Emit;

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

            /*
            Vehiculo vehiculo1 = new Vehiculo();
            Console.WriteLine("Tu marca del auto es " + vehiculo1.Marca);

            Auto auto1 = new Auto();
            Console.WriteLine("El auto es " + auto1.Marca);
            Console.WriteLine("El modelo del auto es " + auto1.Modelo);
            */

            //CALCULADORA
            /*
            Calculadora calculadora1 = new Calculadora();
            Console.WriteLine("Escribe la opcion que desees hacer");
            Console.WriteLine("1 para sumar");
            Console.WriteLine("2 para restar");
            Console.WriteLine("3 para multiplicar");
            Console.WriteLine("4 para dividir");
            int opcion = 0;
            opcion = Convert.ToInt32(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    opcion = 1;
                    Console.WriteLine("Escribe el primer numero");
                    double numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Escribe el segundo numero");
                    double numero2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(calculadora1.Sumar(numero1, numero2));
                    break;

                case 2:
                    opcion = 2;
                    Console.WriteLine("Escribe el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Escribe el segundo numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(calculadora1.Restar(numero1, numero2));
                    break;

                case 3:
                    opcion = 3;
                    Console.WriteLine("Escribe el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Escribe el segundo ahora");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(calculadora1.Multiplicar(numero1, numero2));

                    break;


                case 4:
                    opcion = 4;
                    Console.WriteLine("Escribe el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Escribe el segundo numero ahora");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(calculadora1.Dividir(numero1, numero2));
                    break;

                default:
                    Console.WriteLine("Solo hay 4 opciones!");
                    break;


            }
            */

            //PERIMETRO Y AREA DE UN RECTANGULO
            /*
             Rectangulo rectangulo1 = new Rectangulo();
            Console.WriteLine("Introduce la altura");
            double largo= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la base");
            double ancho= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area de tu rectangulo es "+ rectangulo1.Area(largo, ancho));
            Console.WriteLine("El perimetro o 'cerco' de tu rectangulo es " + rectangulo1.Perimetro(largo, ancho));
            */


            //AUTOR Y TITULO DE UN LIBRO
            /*
            Libro libro1 = new Libro();
            Console.WriteLine("Escribe el titulo del libro");
             libro1.titulo = Console.ReadLine();
            Console.WriteLine("Escribe el autor del libro");
            libro1.autor= Console.ReadLine();
            Console.WriteLine("El titulo del libro es " + libro1.titulo);
            Console.WriteLine("El autor del libro es " + libro1.autor);
            */
            public struct Coords
        {
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; }
            public double Y { get; }

            public override string ToString() => $"({X}, {Y})";
        }


    }
    }
}