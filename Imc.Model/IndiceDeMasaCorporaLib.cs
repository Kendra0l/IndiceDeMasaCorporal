using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Model
{
    public class IndiceDeMasaCorporaLib
    {
        public static decimal IndiceDeMasaCorporal(decimal peso, decimal estatura)
        {
            return peso / (estatura * estatura);
        }

        public static string DeterminaEstadoNutricional(decimal imc)
        {
            if (imc < 18.5m)
            {
                return "Peso bajo";
            }
            if (imc < 25.00m)
            {
                return "Peso normal";
            }
            if (imc < 30.0m)
            {
                return "Sobrepeso";
            }
            if (imc < 40.0m)
            {
                return "Obesidad";
            }

            {
                return "Obesidad extrema";
            }
        }
    }
}
