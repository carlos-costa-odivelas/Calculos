using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos\n");

            int n1, n2;
            Console.Write("Primeiro valor? ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor? ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Soma = {Aritmetica.Somar(n1, n2)}\n");
            Console.WriteLine($"Diferença = {Aritmetica.Subtrair(n1, n2)}\n");

            double t1 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.CelsiusFahrenheit, 36);
            double t2 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.FahrenheitCelsius, 100);

            Console.WriteLine($"36º Celsius = {t1}º Fahrenheit\n");
            Console.WriteLine($"100º Fahrenheit = {t2}º Celsius\n");

            Console.ReadKey();
        }
    }
}
