using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Logica;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "caceresjuancruz01@gmail.com";
            Console.WriteLine("Email " + email.EsUnCorreo());
            string cuit = "20427003818";
            Console.WriteLine("CUIT " + cuit.EsUnCUIT());

            Cliente nuevoCliente1 = new Cliente() { Nombre="Diego Perez", CUIT="20212867368", Saldo=10000};
            Cliente nuevoCliente2 = new Cliente() { Nombre = "Carlos Gutierrez", CUIT = "20212867368", Saldo = 7000};
            Cliente clienteResultado = nuevoCliente1 - nuevoCliente2;
            Console.WriteLine(clienteResultado.Saldo);


            Console.ReadKey();
        }
    }
}
