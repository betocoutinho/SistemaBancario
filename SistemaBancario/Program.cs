using System;
using System.Globalization;

namespace SistemaBancario {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            double deposito = 0;
            if (resposta == 's') {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            ContaBancaria conta1 = new ContaBancaria(nome, conta, deposito);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta1);

            Console.WriteLine("Entre um valor para depósito: ");
            conta1.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta1);

            Console.WriteLine("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Saque(saque);
            
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta1);


        }
    }
}
