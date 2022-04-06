using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Rectangulo
    {
        //No es valido, nadie podria setear los valores
        private static decimal Base { get; set; }
        private static decimal Altura { get; set; }

        public static decimal CalcularPerimetro() //aca van parametros de base y altura
        {
            return 2 * (Base + Altura);
        }

        public static decimal CalcularArea() //aca van parametros de base y altura
        {
            return Base * Altura;
        }
    }
}
