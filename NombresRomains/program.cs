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
            if (nombreArabe == 6)
                return "VI";
            if (nombreArabe == 7)
                return "VII";
            if (nombreArabe == 8)
                return "VIII";
            if (nombreArabe == 9)
                return "IX";
            if (nombreArabe == 10)
                return "X";
            if (nombreArabe == 50)
                return "L";
            if (nombreArabe == 100)
                return "C";
            return "I";
        }
    }
}
