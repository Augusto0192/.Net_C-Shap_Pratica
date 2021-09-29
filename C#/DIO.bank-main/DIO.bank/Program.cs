using System;
using System.Collections.Generic;

namespace DIO.bank
{
    class Program
    {

        static List<Conta> listaContas = new List<Conta>();

        static void Main(string[] args)
        {
            ContextStaticAttribute minhaConta = new Conta();
            string opcaoUsuario = ObterOpcaoUsuario();
            while opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case"1":
                   ListarConta();
                    break;
                    case"2":
                    InserirConta();
                    break;
                    case"3":
                    Transfeir();
                    break;
                    case"4":
                    Sacar();
                    break;
                    case"5":
                    Depositar();
                    break;
                    case"C":
                    Console.Clear();
                    break;
                    default:
                    throw new ArgumentOutOfRangeException();
                }
            }


        }

        private static void Transfeir()
        {
             Console.WriteLine("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser transferido: ");
            double valortransferencia= double.Parse(Console.ReadLine());

            listaContas[indiceContaOrigem].Transferir(valortransferencia, listaContas[indiceContaDestino]);
        }

        private static void Depositar()
        {
             Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser Depositado: ");
            double valorDeposito= double.Parse(Console.ReadLine());

            listaContas[indiceConta].Depositar(valorDeposito);
        }

        private static void Sacar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser sacado: ");
            double valorDeposito= double.Parse(Console.ReadLine());

            listaContas[indiceConta].Sacar(valorDeposito);
        }

        private static void ListarConta()
        {
            Console.WriteLine("Listar Contas");

            if(listaContas.Count == 0)
            {Console.WriteLine("Nenhuma Conta Cadastrada.")
            return;
            }
            for(int i = 0; i< listaContas.Count; i++)
            {
                Conta conta = listaContas[1];
                Console.Write("#{0} .", i);
                Console.WriteLine(conta);


            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");

            Console.WriteLine("Digite 1 para Conta Fisica ou 2 para Juridica");
            int entradaItpoConta = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite Nome do Cliente ");
            string entradaNome =(Console.ReadLine());

            Console.WriteLine("Digite o Saldo Inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());
            
            Conta novaConta = NewsStyleUriParser Conta(TipoConta: (TipoConta)entradaItpoConta,
                                                        saldo: entradaSaldo,
                                                        credito: entradaCredito,
                                                        nome: entradaNome );
            listaContas.Add(novaConta);
            
            
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Dio Bank a seu dispor!");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1- Listar Contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Lispar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
