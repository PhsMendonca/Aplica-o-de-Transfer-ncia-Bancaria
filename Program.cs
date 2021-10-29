using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static List<Conta> ListContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaousuario = obteropcaousuario();

            while (opcaousuario.ToUpper() != "x")
            {
                switch (opcaousuario)
                {
                    case "1":
                        //ListarContas();
                        break;
                    case "2":
                        InserirContas();
                        break;
                    case "3":
                        //Transferir();
                        break;
                    case "4":
                        //Sacar();
                        break;
                    case "5":
                        //Depositar();
                        break;
                    case "C":
                        //Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaousuario = obteropcaousuario();
            }
            Console.WriteLine("obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void InserirContas()
        {
            Console.WriteLine("Inserir nova Conta");
            Console.WriteLine("Digite 1 para Conta Fisica ou 2 para Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do Cliente:");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta, saldo: entradaSaldo, credito: entradaCredito, nome: entradaNome);

            ListContas.Add(novaConta);
        }

        private static string obteropcaousuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu dispor");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1- Lista contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaousuario = Console.ReadLine(). ToUpper();
            Console.WriteLine();
            return opcaousuario;
        }
    }
}

