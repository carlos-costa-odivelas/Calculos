using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculos.Aritmetica;

namespace Calculos
{
    /// <summary>
    /// Implementa métodos de conversão
    /// </summary>
    internal static class Conversoes
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
        /// Método de conversão de temperaturas
        /// </summary>
        /// <param name="conversao">Conversão a efetuar</param>
        /// <param name="temperatura">Temperatura a converter</param>
        /// <returns>Devolve o resultado da conversão.</returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
                return temperatura * 1.8 + 32;
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
                return (temperatura - 32) / 1.8;
            else
                return temperatura;
        }

    }
}
