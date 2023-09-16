using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos.Class
{
    internal class Rectangulo
    {
        public double Area(double largo, double ancho)
        {
            double resultado = largo * ancho;
            return (resultado) ;
        }

        public double Perimetro(double largo, double ancho)
        {
            double resultado2 = largo + ancho;
            return resultado2 ;
        }


    }
}
