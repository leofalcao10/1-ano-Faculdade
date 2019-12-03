using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class Program
    {
        class ContaCorrente
        {
            //Campos
            private float _saldo, _credito, _debito;
            public float SaldoAnterior { get; private set; }

            static float[] totCred = new float[100];
            string[] descCred = new string[totCred.Length];
            string[] horaCred = new string[totCred.Length];
            
            static float[] totDeb = new float[100];
            string[] descDeb = new string[totDeb.Length];
            string[] horaDeb = new string[totDeb.Length];

            int[] limite = { 0, 0 };
            
            //Construtor
            public ContaCorrente()
            {
                _credito = _debito = SaldoAnterior = _saldo = 0;
            }

            //Métodos para Crédito
            public float Credito
            {
                get { return _credito; }
            }
            public void AdicionarCredito()
            {
                 if (limite[0] > 99)
                 {
                    Console.WriteLine("Função inválida, você atingiu o limite de lançamentos.");
                    Console.ReadKey();
                 }
                 else
                 {
                    Console.Write("Lançamento a crédito: ");
                        _credito = float.Parse(Console.ReadLine());

                    Console.Write("Descrição: ");
                        descCred[limite[0]] = Console.ReadLine();

                    Console.Write("Data do lançamento(dd/mm/aa): ");
                        horaCred[limite[0]] = Console.ReadLine();

                    SaldoAnterior = Saldo;

                    //Adicionando crédito ao saldo e posteriormente salvando no histórico de créditos.
                    _saldo += Credito;
                    totCred[limite[0]] = _credito;

                    limite[0]++;
                 }
            }
            
            //Métodos para Débito
            public float Debito
            {
                get { return _debito; }
            }
            public void AdicionarDebito()
            {
                if (limite[1] > 99)
                {
                    Console.WriteLine("Função inválida, você atingiu o limite de lançamentos.");
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Lançamento a débito: ");
                        _debito = float.Parse(Console.ReadLine());

                    Console.Write("Descrição: ");
                        descDeb[limite[1]] = Console.ReadLine();

                    Console.Write("Data do lançamento(dd/mm/aa): ");
                        horaDeb[limite[1]] = Console.ReadLine();

                    SaldoAnterior = Saldo;

                    //Debitando do saldo e posteriormente salvando a ação no histórico de débitos.
                    _saldo -= Debito;
                    totDeb[limite[1]] = _debito;

                    limite[1]++;
                }
            }
           
            //Método para Saldo
            public float Saldo
            {
                get { return _saldo; }
            }

            //Método para mostrar Extrato
            public void MostraExtrato()
            {
                Console.WriteLine("Créditos totais");

                for (int i = 0; i < limite[0]; i++)
                {
                    Console.WriteLine("{0}: {1:C} {2}", descCred[i],totCred[i], horaCred[i]);
                }

                Console.WriteLine();

                Console.WriteLine("Débitos totais");

                for (int i = 0; i < limite[1]; i++)
                {
                    Console.WriteLine("{0}: {1:C} {2}", descDeb[i], totDeb[i], horaDeb[i]);
                }

                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            char opcao;
            bool sair = false;

            ContaCorrente conta = new ContaCorrente();
            
            do
            {
                Console.Clear();

                Console.WriteLine("1 - Lançar crédito\n2 - Lançar débito\n3 - Saldo anterior\n4 - Saldo atual\n5 - Extrato\n6 - Sair");

                opcao = Char.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                        conta.AdicionarCredito();
                        break;

                    case '2':
                        conta.AdicionarDebito();
                        break;

                    case '3':
                        Console.WriteLine($"Saldo anterior: {string.Format("{0:C}", conta.SaldoAnterior)}");
                        Console.ReadKey();
                        break;

                    case '4':
                        Console.Write("Saldo: {0:C} ", conta.Saldo);
                        Console.ReadKey();
                        break;
                    
                    case '5':
                        conta.MostraExtrato();
                        Console.ReadKey();
                        break;

                    case '6':
                        sair = true;
                        break;
                }

            } while (sair == false);

            Console.WriteLine("Encerrando o programa...");
            Console.ReadKey();
        }
    }
}
