using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Rectangulo
    {
        private static decimal Base { get; set; }
        private static decimal Altura { get; set; }

        public static decimal CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }

        public static decimal CalcularArea()
        {
            return Base * Altura;
        }
    }
}
