using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas.
    /// </summary>
    internal static class Aritmetica
    {
        /// <summary>
        /// Tipo de conversão de temperatura a considerar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        /// <summary>
        /// Operação Soma.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Devolve a soma de dois números inteiros.</returns>
        public static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }
        /// <summary>
        /// Operação de subtração.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Devolve a diferneça entre dois números inteiros.</returns>
        public static int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura) {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
                return temperatura * 1.8 + 32;
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
                return (temperatura - 32) / 1.8;
            else
                return temperatura;
        }

    }
}
