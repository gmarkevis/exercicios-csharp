using System;
using System.Globalization;

namespace Mod4_Estatico {
    class Program {


        static void Main(string[] args) {
            /*------------------Exemplo Métodos Estáticos-----------------
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));*/

            /*------------------Exercício de fixação-----------------*/

            Console.Write("Qual a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em Reais: R$ " 
                + ConversorDeMoeda.dolarParaReal(quantidade, cotacao).ToString("F2", CultureInfo.InvariantCulture));
            
        }

    }
}
