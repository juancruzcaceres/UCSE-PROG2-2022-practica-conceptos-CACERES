using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Logica
{
    public static class Extensiones
    {
        public static int CantidadPalabras(this string s) //nombrar mejor la variable
        {
            string[] palabras = s.Split(' ');
            return palabras.Length; // podria tener el return en 1 sola linea
        }

        public static int CantidadPalabras(this string s, char separador)
        {
            string[] palabras = s.Split(separador);
            return palabras.Length;
        }

        public static decimal DiferenciaFechas(DateTime fecha1, DateTime fecha2)
        {
            decimal segundos = (decimal)(fecha1 - fecha2).TotalSeconds;
            return segundos / 60; // podria tener el return en 1 sola linea
        }

        public static double PromedioLista(this List<int> listaInt) //no hace falta el "Int" en el nombre
        {
            return listaInt.Average();
        }

        public static int SumaParesPorRestaImpares(this List<int> listaInt)
        {
            int suma = listaInt.Sum(x => x % 2 == 0 ? x : 0);
            int resta = listaInt.Sum(x => x % 2 != 0 ? -x : 0);

            return suma * resta;
        }

        public static DateTime ConvertirFecha(this string s) // nombrar mejor
        {
            try
            {
                return Convert.ToDateTime(s);
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }

        public static string InvertirString(this string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public static string ConvertirAString(this string[] array, char separador)
        {
            return string.Join(separador.ToString(), array);
        }

        public static bool EsUnCorreo(this string email)
        {
            string EMAIL_REGEX = "^[0-9a-zA-Z]+[.-_+]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
            return Regex.IsMatch(email, EMAIL_REGEX);
        }

        public static bool EsUnCUIT(this string cuit)
        {
            string CUIT_REGEX = "^[2-3]{1}[0-9]{10}$";
            return Regex.IsMatch(cuit, CUIT_REGEX);
        }

        public static int Restar(this int num1, int num2)
        {
            return num1 - num2;
        }

        //Para el punto 14, segun lo que pude investigar, no se puede sobrecargar operadores para el tipo de dato int.

    }
}
