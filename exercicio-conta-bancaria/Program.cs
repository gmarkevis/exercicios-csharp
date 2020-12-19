using System;
using System.Globalization;

namespace ExercicioFixacao {
    class Program {
        static void Main(string[] args) {
            ContaBancaria c;
            Console.Write("Entre o número da conta: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
                        
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(id, nome, depositoInicial);   
            }
            else {
                c = new ContaBancaria(id, nome);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c.ToString());

            Console.WriteLine();

            double quantia;
            Console.Write("Entre com um valor para depósito: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(quantia);

            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c.ToString());

            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(quantia);

            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c.ToString());


        }
    }
}
