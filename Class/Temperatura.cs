using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos.Class
{
   public struct Temperatura
    {
        public double celius { get; set; }

        public double Convertir(double celius)
        {
            double resultado= celius * 9 / 5 + 32;
            return resultado;
        }
    }
}
