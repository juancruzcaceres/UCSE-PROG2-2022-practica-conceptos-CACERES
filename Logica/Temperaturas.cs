using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Temperaturas
    {

        public static double ConvertirEnFarenheit(double gradosCelsius)
        {
            return gradosCelsius * 2.12;
        }

        public static double ConvertirEnCelsius(double gradosFarenheit)
        {
            return gradosFarenheit / 2.12;
        }
    }
}
