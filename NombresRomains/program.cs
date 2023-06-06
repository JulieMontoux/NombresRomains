using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombresRomains
{
    public static class Convertisseur
    {
        public static string Convertir(int nombreArabe)
        {
            if (nombreArabe == 2)
                return "II";
            if (nombreArabe == 3)
                return "III";
            if (nombreArabe == 4)
                return "IV";
            if (nombreArabe == 5)
                return "V";
            return "I";
        }
    }
}
