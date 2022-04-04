using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public decimal Saldo { get; set; }

        public static Cliente operator -(Cliente cliente1, Cliente cliente2)
        {
            Cliente clienteNuevo = new Cliente();
            clienteNuevo.Saldo = cliente1.CUIT == cliente2.CUIT ? cliente1.Saldo - cliente2.Saldo : Math.Min(cliente1.Saldo, cliente2.Saldo);
            return clienteNuevo;
        }
    }
}
